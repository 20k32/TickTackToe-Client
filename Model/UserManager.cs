using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model
{
    internal class UserManager
    {
        public static string Jwt;
        public static string UserId;
        public static string UserName;
        public static bool IsAnonymous => string.IsNullOrWhiteSpace(Jwt);

        private static double _rating;
        public static double Rating
        {
            get => _rating;
            
            set
            {
                if(_rating + value <= 0d)
                {
                    _rating = 0d;
                }
                else
                {
                    _rating = value;
                }
            }
        }
    }
}
