using Shared.Api.Request;
using Shared.Api.Result;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TickTackToe.Model.Helpers
{
    internal class ApiHelper
    {
        public static async Task<TokenResult> SendLoigRequestAsync(UserAuthRequest userAuth, CancellationTokenSource cts)
        {
            TokenResult result = null;

            using(var httpClient = HttpClientHelper.CreateClient())
            {
                try
                {
                    var resultRaw = await httpClient.PostAsJsonAsync("api/auth/login", userAuth, cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        result = await resultRaw.Content.ReadFromJsonAsync<TokenResult>(cts.Token);
                    }
                    else
                    {
                        result = new(null, null, "Server not responds at the current moment, please try later.", -1);
                    }
                }
                catch
                {
                    result = new(null, null, "Server not responds at the current moment, please try later.", -1);
                }
            }

            return result;
        }

        public static async Task<TokenResult> SendRegisterRequestAsync(UserAuthRequest userAuth, CancellationTokenSource cts)
        {
            TokenResult result = null;

            using (var httpClient = HttpClientHelper.CreateClient())
            {
                try
                {
                    var resultRaw = await httpClient.PostAsJsonAsync("api/auth/register", userAuth, cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        result = await resultRaw.Content.ReadFromJsonAsync<TokenResult>(cts.Token);
                    }
                    else
                    {
                        result = new(null, null, "Server not responds at the current moment, please try later.", -1);
                    }
                }
                catch
                {
                    result = new(null, null, "Server not responds at the current moment, please try later.", -1);
                }
            }

            return result;
        }

        public static async Task<UserResult> SendGetMyInfoRequestAsync(CancellationTokenSource cts)
        {
            UserResult result = null;

            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                var resultRaw = await httpClient.GetAsync("api/users/my");

                if (resultRaw.IsSuccessStatusCode)
                {
                    result = await resultRaw.Content.ReadFromJsonAsync<UserResult>(cts.Token);
                }
                else
                {
                    result = new(null, "Server not responds at the current moment, please try later.", -1);
                }

                return result;
            }
        }
    }
}
