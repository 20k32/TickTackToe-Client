using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Presenter
{
    internal class LoginFormPresenter : PresenterBase
    {
        public LoginFormPresenter(IServiceProvider provider) : base(provider)
        {
        }

        public override void OnClosed(object sender, FormClosedEventArgs e)
        {
            var form = (KryptonForm)sender;
            form.Load -= OnLoaded;
        }

        public override void OnLoaded(object sender, EventArgs e)
        {
            var form = (KryptonForm)sender;
            LoadSettings(form);
        }
    }
}
