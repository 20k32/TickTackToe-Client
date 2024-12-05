using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using Shared.Api.Models;
using Shared.Api.Request;
using Shared.Api.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model;
using TickTackToe.Model.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TickTackToe.Presenter
{
    internal class LoginFormPresenter : PresenterBase
    {
        private CancellationTokenSource cts;
        private KryptonWrapLabel statusValueLabel;
        IServiceProvider _provider;

        public LoginFormPresenter(IServiceProvider provider) : base(provider)
        {
            UserManager.NewUserEntryCreated += OnNewUserCreated;
            _provider = provider;
        }

        private async void OnNewUserCreated()
        {
            var connectionWrapper = _provider.GetService<HubConnectionWrapper>();

            if (connectionWrapper is not null && connectionWrapper.Connection is not null)
            {
                await connectionWrapper.Connection.DisposeAsync();
                connectionWrapper.Connection = null;
            }
        }

        public override void OnClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();

            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
            statusValueLabel = null;
        }

        public override void OnLoaded(object sender, EventArgs e)
        {
            var form = (KryptonForm)sender;
            LoadSettings(form);
        }

        public void SetStatusValueLabel(KryptonWrapLabel label) => statusValueLabel = label;

        public async Task LoginAsync(string userName, string password)
        {
            statusValueLabel.Text = "Loading...";
            if (cts is not null)
            {
                cts.Cancel();
            }

            cts = new();
            var userAuthRequest = new UserAuthRequest(userName, password);
            try
            {
                var responce = await ApiHelper.SendLoigRequestAsync(userAuthRequest, cts);
                await AssingToUserManagerAsync(cts, responce);
            }
            catch (TaskCanceledException) { }

        }

        public async Task RegisterAsync(string userName, string password)
        {
            statusValueLabel.Text = "Loading...";
            if (cts is not null)
            {
                cts.Cancel();
            }

            cts = new();
            var userAuthRequest = new UserAuthRequest(userName, password);
            try
            {
                var responce = await ApiHelper.SendRegisterRequestAsync(userAuthRequest, cts);
                await AssingToUserManagerAsync(cts, responce);
            }
            catch (TaskCanceledException) { }
        }


        private async Task AssingToUserManagerAsync(CancellationTokenSource cts, ApiResult<TokenResult> responce)
        {
            if (!cts.IsCancellationRequested)
            {
                if (responce.IsSuccessStatusCode)
                {
                    UserManager.Jwt = responce.Value.Token;
                    UserManager.UserId = responce.Value.UserId;
                    await LoadDataToUserManagerAsync(cts);
                }

                statusValueLabel.Text = responce.Message;
            }
        }

        private async Task LoadDataToUserManagerAsync(CancellationTokenSource cts)
        {
            var result = await ApiHelper.SendGetMyInfoRequestAsync(cts);
            if (!cts.IsCancellationRequested)
            {
                if (result.IsSuccessStatusCode)
                {
                    UserManager.UserName = result.Value.UserName;
                    UserManager.LocalGameHistory = result.Value.GameHistory;
                    UserManager.Rating = result.Value.Rating;
                }
            }
        }
    }
}
