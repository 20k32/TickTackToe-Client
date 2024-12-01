using Accessibility;
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
            _presenter.SetLogTextBox(logRichTextBox);
            _presenter.SetLogListBox(logListBox);
            _presenter.SetShowStatsButton(showStatsButton);
            _presenter.SetPlayButton(playButton);

            FormClosed += _presenter.OnClosed;
            Load += _presenter.OnLoaded;
        }

        private void OnShowStatsButtonClick(object sender, EventArgs e)
        {
            _presenter.ShowStats();
        }

        private async void OnLoginButtonClick(object sender, EventArgs e)
        {
           await _presenter.ShowLoginAsync();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            _presenter.ShowGameForm();
        }
    }
}
