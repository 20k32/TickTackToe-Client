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
    internal sealed class GameFormPresenter : PresenterBase
    {
        GameForm _gameForm;

        public GameFormPresenter(IServiceProvider provider) : base(provider)
        {
            _gameForm = provider.GetService<GameForm>();
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
    }
}
