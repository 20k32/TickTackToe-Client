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
        public static int Rating;
    }
}
