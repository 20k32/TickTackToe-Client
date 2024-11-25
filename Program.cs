using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using TickTackToe.Model;
using TickTackToe.Model.Helpers;
using TickTackToe.Presenter;
using TickTackToe.View;

namespace TickTackToe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var collection = new ServiceCollection();

            collection.ConfigureServices();
            collection.ConfigureApp();
            HttpClientHelper.SetBaseAddress(ApiSettings.ApiHttpUrl);

            var provider = collection.BuildServiceProvider();
            var mainForm = provider.GetService<MainForm>();

            Application.Run(mainForm);
        }
    }
}