using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;
using TickTackToe.Model;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    internal sealed class MainFormPresenter : PresenterBase
    {
        private readonly IServiceProvider _provider;
        private MainForm _mainForm;

        public MainFormPresenter(IServiceProvider provider) : base(provider)
        {
            _provider = provider;
        }

        public override void OnClosed(object sender, FormClosedEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
        }

        public override void OnLoaded(object sender, EventArgs e)
        {
            LoadSettings((KryptonForm)sender);
        }

        public void ShowStats()
        {
            var statsForm = ServiceProvider.GetService<StatsForm>();
            statsForm.ShowDialog(_mainForm);
        }

        public void ShowLogin()
        {
            var loginForm = ServiceProvider.GetService<LoginForm>();
            loginForm.ShowDialog(_mainForm);
        }
    }
}
