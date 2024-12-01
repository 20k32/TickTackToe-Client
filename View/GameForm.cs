using Accessibility;
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
using TickTackToe.Model;
using TickTackToe.Presenter;

namespace TickTackToe.View
{
    public partial class GameForm : KryptonForm
    {
        GameFormPresenter _presenter;

        public GameForm(IServiceProvider provider)
        {
            InitializeComponent();

            _presenter = provider.GetService<GameFormPresenter>();

            _presenter.LoadButtons(
                game00button,
                game01Button,
                game02Button,
                game10Button,
                game11Button,
                game12Button,
                game20Button,
                game21Button,
                game22Button);

            _presenter.SetRichTextBoxToLog(statusTextBox);
            _presenter.SetGameTimerTextBox(timerTextBox);

            Text = UserManager.UserName;

            Load += _presenter.OnLoaded;
            FormClosing += _presenter.OnClosing;
        }

        private void game00button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(0, 0);
        }

        private void game01Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(0, 1);
        }

        private void game02Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(0, 2);
        }

        private void game10Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(1, 0);
        }

        private void game11Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(1, 1);
        }

        private void game12Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(1, 2);
        }

        private void game20Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(2, 0);
        }

        private void game21Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(2, 1);
        }

        private void game22Button_Click(object sender, EventArgs e)
        {
            _presenter.TryMakeTurn(2, 2);
        }
    }
}
