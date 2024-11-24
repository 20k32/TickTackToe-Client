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
    public partial class StatsForm : KryptonForm
    {
        StatsFormPresenter _presenter;

        public StatsForm(IServiceProvider provider)
        {
            InitializeComponent();

            _presenter = provider.GetService<StatsFormPresenter>();
            Load += _presenter.OnLoaded;
            FormClosed += _presenter.OnClosed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
