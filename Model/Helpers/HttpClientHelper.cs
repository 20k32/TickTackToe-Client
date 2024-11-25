using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model.Helpers
{
    internal class HttpClientHelper
    {
        private static Uri _baseAddress;
        
        public static void SetBaseAddress(string address) => _baseAddress = new(address);
        
        public static HttpClient CreateClient() => new()
        {
            BaseAddress = _baseAddress
        };

        public static HttpClient CreateAuthorizedClient() => new()
        {
            BaseAddress = _baseAddress,
            DefaultRequestHeaders = 
            {
                { "Authorization", $"Bearer {UserManager.Jwt}" }
            }
        };
    }
}
