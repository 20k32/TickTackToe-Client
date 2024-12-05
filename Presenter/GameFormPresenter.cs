using Krypton.Toolkit;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using Shared.Api.Messages;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model;
using TickTackToe.Model.GameLogic;
using TickTackToe.Model.Helpers;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    internal sealed class GameFormPresenter : PresenterBase
    {
        private static bool _isNewUserEntry = true;
        private static bool _isFirstInit = true;

        private bool _isGameEndedMessageReceived;
        private bool _isExitRequestReceived;
        private bool _isExitRequestSended;
        private bool _isExitRequestApproved;
        private bool _isGameStarted;

        private string _senderId;
        private string _senderUserName;

        private GameChangedParameter _gameState;
        private GameCore _game;

        private KryptonButton[,] _buttons;
        private KryptonRichTextBox _logBox;
        private KryptonTextBox _timerTexBox;

        private HubConnectionWrapper _connectionWrapper;
        
        private System.Threading.Timer _gameTimer;
        private Stopwatch _stopwatch;
        
        private CancellationTokenSource _cancellationSource;
        

        public GameFormPresenter(IServiceCollection collection) : base(collection.BuildServiceProvider())
        {
            UserManager.NewUserEntryCreated += OnNewUserCreated;

            _game = ServiceProvider.GetService<GameCore>();
            _game.FieldChangedByMe += OnFieldChangedByMe;
            _game.GameEndedWithWinner += OnGameEnded;

            _connectionWrapper = ServiceProvider.GetService<HubConnectionWrapper>();

            _cancellationSource = new();
            _stopwatch = new();
        }

        private static void OnNewUserCreated()
        {
            _isNewUserEntry = true;
        }

        private void ExitRequested(bool isExitRequestApproved)
        {
            _logBox.Invoke(() =>
            {
                _isExitRequestReceived = true;
                _logBox.Text += "\nYour opp requested exit. You can exit from game to allow him to exit.";
            });
        }

        private void ExitApproved(bool isExitRequestApproved)
        {
            _isExitRequestApproved = true;

            _logBox.Invoke(() =>
            {
                _logBox.Text += $"\nOpp exited and you also can.";
            });
        }

        private async void OnGameEnded(TickTackType type)
        {
            if(!_isGameEndedMessageReceived)
            {
                _isGameEndedMessageReceived = true;

                var isMeWinner = _game.Me.Type == type;
                
                var points = _game.DefineRawPoints();
                var bonusPoints = _game.DefineBonus(_stopwatch.Elapsed.TotalMinutes);
                var totalPoints = bonusPoints * points;

                if (!isMeWinner)
                {
                    totalPoints *= -1;
                }

                UserManager.Rating += totalPoints;

                var gameHistory = new GameHistoryDto(_timerTexBox.Text, _senderUserName, totalPoints);
                UserManager.LocalGameHistory.Add(gameHistory);

                var winnerString = isMeWinner ? "win" : "loose";
                _logBox.Text += $"\nGame Ended! You {winnerString}. Your rating: {UserManager.Rating}";

                DisposeInternal();

                var existingUserRequest = await ApiHelper.SendGetMyInfoRequestAsync(_cancellationSource);

                existingUserRequest.Value.Rating = UserManager.Rating;
                existingUserRequest.Value.GameHistory = UserManager.LocalGameHistory;

                if (existingUserRequest.IsSuccessStatusCode)
                {
                    var updateRequest = await ApiHelper.SendUpdateMyInfo(existingUserRequest.Value, _cancellationSource);

                    if (!updateRequest.IsSuccessStatusCode)
                    {
                        MessageBox.Show(updateRequest.Message, "Failed to update your data.");
                    }
                }
            }
        }

        private void DisposeInternal()
        {
            _gameTimer?.Dispose();
            _stopwatch?.Reset();
        }

        public void LoadButtons(params KryptonButton[] buttons)
        {
            _buttons = new KryptonButton[GameCore.FiedlWidth, GameCore.FiedlWidth];
            int i, j;

            i = j = 0;
            foreach(var item in buttons)
            {
                _buttons[i, j] = item;
                
                i++;
                if(i == GameCore.FiedlWidth)
                {
                    i = 0;
                    j++;
                }
            }
        }
        
        private void ChangeButtonStateCore(bool isCross, int posX, int posY)
        {
            var iconPath = isCross
              ? ResourcesFolder.PathToCrossIcon
              : ResourcesFolder.PathToZeroIcon;

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, iconPath);
            var image = Image.FromFile(path);

            _buttons[posY, posX].Values.Image = image;
        }

        private async void OnFieldChangedByMe(bool isCross, int posX, int posY)
        {
            var parameter = _game.SaveState();
            parameter.ToUserId = _senderId;

            await _connectionWrapper.Connection.SendAsync("GameHappening", parameter);

            _logBox.Invoke(() =>
            {
                ChangeButtonStateCore(isCross, posX, posY);
                _logBox.Text += $"\nopponents turn.";
                _game.CheckForGameCompletion();
            });
        }

        private void LoadGameState(GameChangedParameter parameter)
        {
            _logBox.Invoke(() =>
            {
                _game.LoadState(parameter);

                ChangeButtonStateCore(parameter.IsCross, parameter.PosX, parameter.PosY);

                if (!_game.CheckForGameCompletion())
                {
                    _logBox.Text += $"\nyour turn.";
                }
            });
        }

        public override async void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (_isGameStarted)
            {
                if (_game.CheckForGameCompletion())
                {
                    ExitCore((KryptonForm)sender);
                }
                else if (_isExitRequestReceived)
                {
                    ApproveExitRequest();
                    ExitCore((KryptonForm)sender);
                }
                else if (!_isExitRequestApproved)
                {
                    e.Cancel = true;

                    if (!_isExitRequestSended)
                    {
                        _isExitRequestSended = true;
                        SendExitRequest();
                        _logBox.Text += "\nYour exit request sended to opp. If he exits, you also may.";
                    }
                }
                else if (_isExitRequestApproved)
                {
                    ExitCore((KryptonForm)sender);
                }
            }
            else
            {
                var removeResult = await ApiHelper.SendRemoveFromPoolRequestAsync(_cancellationSource);
                
                if (removeResult.IsSuccessStatusCode)
                {
                    ExitCore((KryptonForm)sender);
                }
                else
                {
                    MessageBox.Show(removeResult.Message, "Failed to remove you from pool");
                    e.Cancel = true;
                }
            }
        }

        private void ApproveExitRequest()
        {
            _connectionWrapper.Connection.SendAsync("ExitRequestApproved", _senderId);
        }

        private void ExitCore(KryptonForm form)
        {
            DisposeInternal();

            form.Load -= OnLoaded;
            _logBox.Text = string.Empty;
        }

        private void SendExitRequest()
        {
            _connectionWrapper.Connection.SendAsync("ExitRequest", _senderId);
        }

        public override async void OnLoaded(object sender, EventArgs e)
        {
            if(_connectionWrapper?.Connection is null)
            {
                MessageBox.Show("Connection is not initialized yet, re-enter game window.", "Failed to connect");
                var form = (KryptonForm)sender;
                form.Close();
            }
            else
            {
                if (_isFirstInit || _isNewUserEntry)
                {
                    _isFirstInit = false;
                    _isNewUserEntry = false;

                    _connectionWrapper.Connection.On<GameStartParameters>("OnStartMessage", GameStart);
                    _connectionWrapper.Connection.On<GameChangedParameter>("OnGameHappening", LoadGameState);
                    _connectionWrapper.Connection.On<bool>("OnExitRequested", ExitRequested);
                    _connectionWrapper.Connection.On<bool>("OnExitApproved", ExitApproved);
                }

                _isGameEndedMessageReceived = false;
                _isExitRequestApproved = false;
                _isExitRequestReceived = false;
                _isExitRequestSended = false;
                _isGameStarted = false;
                LoadSettings((KryptonForm)sender);

                var result = await ApiHelper.SendAddToPoolRequestAsync(_cancellationSource);

                if (!result.IsSuccessStatusCode)
                {
                    MessageBox.Show(result.Message, "Failed to connect");
                }
            }
        }

        private void OnGameTimerTick(object sender, EventArgs e)
        {
            _timerTexBox.Invoke(() =>
            {
                _timerTexBox.Text = $"{_stopwatch.Elapsed:mm\\:ss}";
            });
        }

        public void GameStart(GameStartParameters parameters)
        {
            _logBox.Invoke(() =>
            {
                _isGameStarted = true;

                _senderUserName = parameters.SenderUserName;
                _senderId = parameters.SenderId;

                _logBox.Text += $"{parameters.SenderUserName}: {parameters.Message}";

                _game.AssignFirstPlayer(parameters.FirstPlayerUserName, parameters.FirstPlayerId);
                _game.AssingSecondPlayer(parameters.SecondPlayerUserName, parameters.SecondPlayerId);
                _game.DefinePlayerForMe(UserManager.UserId);

                _gameTimer = new(_ => OnGameTimerTick(null, null));
                _gameTimer.Change(0, 1000);
                _stopwatch.Start();
                _game.ResetState();

                if (_game.Me.Type == TickTackType.Cross)
                {
                    _logBox.Text += $"\nyour turn";
                }
                else
                {
                    _logBox.Text += $"\nopponents turn";
                }
            });
        }

        public void SetRichTextBoxToLog(KryptonRichTextBox textBox) => _logBox = textBox;

        public void TryMakeTurn(int posX, int posY)
        {
            if (_isExitRequestApproved)
            {
                _logBox.Text = "You can't make turn because opponent exited!";
            }
            else if (_isGameStarted)
            {
                var result = _game.MakeTurn(posX, posY, _senderId);
            }
            else
            {
                _logBox.Text = "The game is not started yet! Wait for an opp";
            }
        }

        internal void SetGameTimerTextBox(KryptonTextBox textBox)
        {
            _timerTexBox = textBox;
        }
    }
}
