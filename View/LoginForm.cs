using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TickTackToe.Presenter;

namespace TickTackToe.View
{
    public partial class LoginForm : KryptonForm
    {
        private LoginFormPresenter _presenter;
        private IServiceProvider _provider;

        public LoginForm(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
            _presenter = _provider.GetService<LoginFormPresenter>();

            _presenter.SetStatusValueLabel(statusValueLabel);

            Load += _presenter.OnLoaded;
            FormClosed += _presenter.OnClosed;
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            await _presenter.LoginAsync(userNameTextBlock.Text, userPasswordMaskedTextBlock.Text);
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            await _presenter.RegisterAsync(userNameTextBlock.Text, userPasswordMaskedTextBlock.Text);
        }
    }
}
