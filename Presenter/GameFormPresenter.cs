using Krypton.Toolkit;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Shared.Api.Messages;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model;
using TickTackToe.Model.Helpers;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    internal sealed class GameFormPresenter : PresenterBase
    {
        private GameChangedParameter _gameState;
        private string _senderId;
        private GameCore _game;
        private KryptonButton[,] _buttons;
        private KryptonRichTextBox _logBox;
        private HubConnection _connection;

        public GameFormPresenter(IServiceCollection collection) : base(collection.BuildServiceProvider())
        {
            _game = ServiceProvider.GetService<GameCore>();
            _game.FieldChangedByMe += OnFieldChangedByMe;
            _connection = ServiceProvider.GetService<HubConnection>();
            _connection.On<GameStartParameters>("OnStartMessage", OnGameStart);
            _connection.On<GameChangedParameter>("OnGameHappening", LoadGameState);
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

        private void OnFieldChangedByMe(bool isCross, int posX, int posY)
        {
            var iconPath = isCross
               ? ResourcesFolder.PathToCrossIcon
               : ResourcesFolder.PathToZeroIcon;

            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, iconPath);
            var image = Image.FromFile(path);

            _buttons[posY, posX].Values.Image = image;

            var parameter = _game.SaveState();
            parameter.ToUserId = _senderId;

            _connection.SendAsync("GameHappening", parameter);
            //todo: check for completion!!!
        }

        private void LoadGameState(GameChangedParameter parameter)
        {
            _game.LoadState(parameter);

            OnFieldChangedByMe(parameter.IsCross, parameter.PosX, parameter.PosY);
        }

        public override void OnClosed(object sender, FormClosedEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;

            _logBox.Text = string.Empty;
        }

        public override async void OnLoaded(object sender, EventArgs e)
        {
            LoadSettings((KryptonForm)sender);

            var opponent = new UserDto("opponent", "", "", 12);

            await _connection.SendAsync("AddToPoolAsync", UserManager.UserName, UserManager.UserId);
        }

        public void OnGameStart(GameStartParameters parameters)
        {
            _logBox.Invoke(() =>
            {
                _senderId = parameters.SenderId;

                _logBox.Text += $"{parameters.SenderUserName}: {parameters.Message}";

                _game.AssignFirstPlayer(parameters.FirstPlayerUserName, parameters.FirstPlayerId);
                _game.AssingSecondPlayer(parameters.SecondPlayerUserName, parameters.SecondPlayerId);
                _game.DefinePlayerForMe(UserManager.UserId);

                if (_game.Me.Type == Model.GameLogic.TickTackType.Cross)
                {
                    _logBox.Text += $"\nsystem: your turn";
                }
            });
        }

        public void SetRichTextBoxToLog(KryptonRichTextBox textBox) => _logBox = textBox;

        public void TryMakeTurn(int posX, int posY)
        {
            var result = _game.MakeTurn(posX, posY, _senderId);
        }
    }
}
