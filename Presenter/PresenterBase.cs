using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model;

namespace TickTackToe.Presenter
{
    internal abstract class PresenterBase
    {
        protected readonly IServiceProvider ServiceProvider;

        protected PresenterBase(IServiceProvider provider) 
        {
            ServiceProvider = provider;
        }

        protected void LoadSettings(KryptonForm form)
        {
            var settings = ServiceProvider.GetService<FormSettings>();
            form.TitleStyle = settings.TitleStyle;
            form.FormTitleAlign = settings.PaletteRelativeAlign;
            form.PaletteMode = settings.PaletteMode;
        }

        public abstract void OnLoaded(object sender, EventArgs e);
        public abstract void OnClosing(object sender, FormClosingEventArgs e);
    }
}
