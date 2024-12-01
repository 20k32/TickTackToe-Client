using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    internal sealed class StatsFormPresenter : PresenterBase
    {
        private readonly IServiceProvider _provider;
        private StatsForm _statsForm;

        public StatsFormPresenter(IServiceProvider provider) : base(provider)
        {
            _provider = provider;
        }

        public override void OnClosing(object sender, FormClosingEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
        }

        public override void OnLoaded(object sender, EventArgs e)
        {
            LoadSettings((KryptonForm)sender);
        }
    }
}
