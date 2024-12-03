using Krypton.Toolkit;
using Shared.Api.Request;
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

namespace TickTackToe.Presenter
{
    internal class LoginFormPresenter : PresenterBase
    {
        private CancellationTokenSource cts;
        private KryptonWrapLabel statusValueLabel;


        public LoginFormPresenter(IServiceProvider provider) : base(provider)
        {
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
                
                if (!cts.IsCancellationRequested)
                {
                    if (responce.StatusCode == 200)
                    {
                        UserManager.Jwt = responce.Value.Token;
                        UserManager.UserName = userName;
                        UserManager.UserId = responce.Value.UserId;
                    }

                    statusValueLabel.Text = responce.Message;
                }
            }
            catch (TaskCanceledException ex) { }

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

                if (!cts.IsCancellationRequested)
                {
                    if (responce.StatusCode == 200)
                    {
                        UserManager.Jwt = responce.Value.Token;
                        UserManager.UserName = userName;
                        UserManager.UserId = responce.Value.UserId;
                    }

                    statusValueLabel.Text = responce.Message;
                }
            }
            catch (TaskCanceledException ex) { }
        }
    }
}
