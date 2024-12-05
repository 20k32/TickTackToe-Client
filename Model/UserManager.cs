using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model
{
    internal static class UserManager
    {
        public static event Action NewUserEntryCreated;

        private static string _previousUserId;

        private static string _userId = string.Empty;
        public static string UserId
        {
            get => _userId;
            set
            {
                _previousUserId = _userId;
                _userId = value;

                if (_previousUserId is not null && !_previousUserId.Equals(_userId))
                {
                    NewUserEntryCreated?.Invoke();
                }
            }
        }

        public static string Jwt;
        public static string UserName;
        public static bool IsAnonymous => string.IsNullOrWhiteSpace(Jwt);

        private static double _rating;
        public static double Rating
        {
            get => _rating;

            set
            {
                if (_rating + value <= 0d)
                {
                    _rating = 0d;
                }
                else
                {
                    _rating = value;
                }
            }
        }

        public static ICollection<GameHistoryDto> LocalGameHistory = new List<GameHistoryDto>();
    }
}
