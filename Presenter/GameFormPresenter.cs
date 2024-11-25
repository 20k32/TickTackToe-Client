using Krypton.Toolkit;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Shared.DTOs;
using System;
using System.Collections.Generic;
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
        private UserDto _me;
        private GameCore _game;
        private KryptonButton[,] _buttons;


        public GameFormPresenter(IServiceProvider provider) : base(provider)
        {
            _me = new(UserManager.UserName, string.Empty, string.Empty, UserManager.Rating);
            _game = provider.GetService<GameCore>();
            _game.FieldChangedByMe += OnFieldChangedByMe;
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

        private void OnFieldChangedByMe((int, int) tuple)
        {
            var player = _game.DefinePlayerForUser(_me);

            var iconPath = player.Type == Model.GameLogic.TickTackType.Cross 
                ? ResourcesFolder.PathToCrossIcon 
                : ResourcesFolder.PathToZeroIcon;


            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, iconPath);
            /*using (var image = Image.FromFile(iconPath))
            {
                _buttons[tuple.Item1, tuple.Item2].BackgroundImage = image;
            }*/

            var image = Image.FromFile(path);
            _buttons[tuple.Item1, tuple.Item2].Values.Image = image;
        }

        public override void OnClosed(object sender, FormClosedEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
        }

        public override void OnLoaded(object sender, EventArgs e)
        {
            LoadSettings((KryptonForm)sender);

            _game.InitPlayersRandomly();
            _game.AssignFirstPlayer(_me);

            var opponent = new UserDto("opponent", "", "", 12);
            _game.AssingSecondPlayer(opponent);
        }

        public async void TryMakeTurn(int posX, int posY)
        {
            var player = _game.DefinePlayerForUser(_me);
            player.Type = Model.GameLogic.TickTackType.Cross;
            var turn = _game.DefineTurn();
            
            var result = _game.MakeTurn(_me, posX, posY);


            //Set connection

            var connection = new HubConnectionBuilder().WithUrl("http://localhost:5283/users").Build();
            connection.On<string>("Receive", (message) =>
            {
                Debug.WriteLine("Received");
            });

            await connection.StartAsync();

            await connection.InvokeAsync("foo", "sdfasdf");

        
        }
    }
}
