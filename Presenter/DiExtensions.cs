using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTackToe.Model;
using TickTackToe.View;

namespace TickTackToe.Presenter
{
    public static class DiExtensions
    {
        public static void ConfigureServices(this IServiceCollection collection)
        {
            //dialog windows
            collection.AddSingleton<MainForm>()
                .AddTransient<GameForm>()
                .AddTransient<StatsForm>()
                .AddTransient<LoginForm>();

            //presenters
            collection.AddSingleton<MainFormPresenter>()
                .AddSingleton<StatsFormPresenter>()
                .AddSingleton<GameFormPresenter>()
                .AddSingleton<LoginFormPresenter>();
        }

        public static void ConfigureApp(this IServiceCollection collection)
        {
            var settings = new FormSettings(
                Krypton.Toolkit.PaletteMode.Microsoft365Black,
                Krypton.Toolkit.KryptonFormTitleStyle.Modern,
                Krypton.Toolkit.PaletteRelativeAlign.Center
                );

            collection.AddSingleton(settings);
        }
    }
}
