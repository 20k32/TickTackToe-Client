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
    public partial class GameForm : KryptonForm
    {
        GameFormPresenter _presenter;

        public GameForm(IServiceProvider provider)
        {
            InitializeComponent();
            _presenter = provider.GetService<GameFormPresenter>();

            Load += _presenter.OnLoaded;
            FormClosed += _presenter.OnClosed;
        }
    }
}
