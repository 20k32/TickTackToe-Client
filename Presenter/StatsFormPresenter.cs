using Krypton.Toolkit;
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
    internal sealed class StatsFormPresenter : PresenterBase
    {
        private readonly IServiceProvider _provider;
        private StatsForm _statsForm;
        private KryptonDataGridView _statsGrid;
        private KryptonLabel _userNameLabel;
        private KryptonLabel _userRatingLabel;

        public void SetStatsDataGrid(KryptonDataGridView dataGrid) => _statsGrid = dataGrid;
        public void SetUserNameLabel(KryptonLabel label) => _userNameLabel = label;
        public void SetUserRatingLabel(KryptonLabel label) => _userRatingLabel = label;

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

            _userNameLabel.Text = UserManager.UserName;
            _userRatingLabel.Text = UserManager.Rating.ToString();

            foreach(var item in UserManager.LocalGameHistory)
            {
                _statsGrid.Rows.Add(item.OpponentName, item.PointsReceived, item.TimeTaken);
            }
        }
    }
}
