using Krypton.Toolkit;
using Microsoft.Extensions.DependencyInjection;
using TickTackToe.Presenter;

namespace TickTackToe
{
    public partial class MainForm : KryptonForm, IWin32Window
    {
        MainFormPresenter _presenter;

        public MainForm(IServiceProvider provider)
        {
            InitializeComponent();
            this.MinimumSize = new(500, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new(800, 700);
            this.PaletteMode = PaletteMode.Microsoft365Black;
            TitleStyle = KryptonFormTitleStyle.Modern;
            FormTitleAlign = PaletteRelativeAlign.Center;
            _presenter = provider.GetService<MainFormPresenter>();

            FormClosed += _presenter.OnClosed;
            Load += _presenter.OnLoaded;
        }

        private void OnShowStatsButtonClick(object sender, EventArgs e)
        {
            _presenter.ShowStats();
        }

        private void OnLoginButtonClick(object sender, EventArgs e)
        {
            _presenter.ShowLogin();
        }
    }
}
