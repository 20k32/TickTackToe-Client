using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model.GameLogic
{
    internal static class GameSettings
    {
        public const double MAX_BONUS_POINTS = 1.5d;
        public const double MIDDLE_BONUS_POINTS = 1.3d;
        public const double MIN_BONUS_POINTS = 1.1d;

        public static readonly TimeSpan MinTime = TimeSpan.FromMinutes(1);
        public static readonly TimeSpan MiddleTime = TimeSpan.FromMinutes(2);
        public static readonly TimeSpan MaxTime  = TimeSpan.FromMinutes(3);

        public const int MIN_RAW_POINTS_BOUND = 50;
        public const int MAX_RAW_POINTS_BOUND = 300;
    }
}
