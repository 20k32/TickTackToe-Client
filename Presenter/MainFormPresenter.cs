using Krypton.Toolkit;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Shared.Api.Messages;
using System.ComponentModel.Design;
using System.Data.Common;
using TickTackToe.Model;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    internal sealed class MainFormPresenter : PresenterBase
    {
        private readonly IServiceCollection _collection;
        private readonly IServiceProvider _provider;
        private MainForm _mainForm;
        private KryptonRichTextBox _logTextBox;
        private KryptonButton _playButton;
        private KryptonButton _showStatsButton;
        private KryptonListBox _logListbox;

        public MainFormPresenter(IServiceProvider provider, IServiceCollection collection) : base(provider)
        {
            _provider = provider;
            _collection = collection;
        }

        public void SetLogTextBox(KryptonRichTextBox textBox) => _logTextBox = textBox;
        public void SetPlayButton(KryptonButton button) => _playButton = button;
        public void SetShowStatsButton(KryptonButton button) => _showStatsButton = button;
        public void SetLogListBox(KryptonListBox listBox) => _logListbox = listBox; 

        private void LoadUIState()
        {
            _logTextBox.Text = string.Empty;

            _logTextBox.Text = "Welcome, ";
            if (UserManager.IsAnonymous)
            {
                _logTextBox.Text += "Anonymous, please, register or log in to play.";
                
                //_logListbox.Enabled = false;
                //_playButton.Enabled = false;
                //_showStatsButton.Enabled = false;
            }
            else
            {
                _logTextBox.Text += $"{UserManager.UserName}, your current rating is: {UserManager.Rating}";
               
                _logListbox.Enabled = true;
                _playButton.Enabled = true;
                _showStatsButton.Enabled = true;
            }
        }

        public override void OnClosing(object sender, FormClosingEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
        }

        public override async void OnLoaded(object sender, EventArgs e)
        {
            LoadSettings((KryptonForm)sender);
            LoadUIState();
        }

        public void ShowStats()
        {
            var statsForm = ServiceProvider.GetService<StatsForm>();
            statsForm.ShowDialog(_mainForm);
        }

        public async Task ShowLoginAsync()
        {
            var loginForm = ServiceProvider.GetService<LoginForm>();
            var result = loginForm.ShowDialog(_mainForm);

            if(!string.IsNullOrEmpty(UserManager.Jwt))
            {
                LoadUIState();
            }

            try
            {
                var connection = new HubConnectionBuilder().WithUrl($"http://localhost:5283/users?access_token={UserManager.Jwt}").Build();
                await connection.StartAsync();

                _collection.AddSingleton(connection);

                _logTextBox.Text += "\nConnected.";
            }
            catch
            {
                _logTextBox.Text += "\nFailed to connect.";
            }
        }

        public void ShowGameForm()
        {
            var gameForm = ServiceProvider.GetService<GameForm>();
            gameForm.ShowDialog(_mainForm);
        }
    }
}
