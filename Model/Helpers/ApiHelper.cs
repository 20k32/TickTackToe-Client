using Newtonsoft.Json;
using Shared.Api.Models;
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
        public static async Task<ApiResult<TokenResult>> SendLoigRequestAsync(UserAuthRequest userAuth, CancellationTokenSource cts)
        {
            ApiResult<TokenResult> result;

            using(var httpClient = HttpClientHelper.CreateClient())
            {
                try
                {
                    var resultRaw = await httpClient.PostAsJsonAsync("api/auth/login", userAuth, cts.Token);
                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<ApiResult<TokenResult>>(json);
                    }
                    else
                    {
                        var tempResult = JsonConvert.DeserializeObject<ApiResult<PlainResult>>(json);
                        result = new(null, tempResult.Message, tempResult.StatusCode);
                    }
                }
                catch
                {
                    result = new(null, "Server not responds at the current moment, please try later.", -1);
                }
            }

            return result;
        }

        public static async Task<ApiResult<TokenResult>> SendRegisterRequestAsync(UserAuthRequest userAuth, CancellationTokenSource cts)
        {
            ApiResult<TokenResult> result = null;

            using (var httpClient = HttpClientHelper.CreateClient())
            {
                try
                {
                    var resultRaw = await httpClient.PostAsJsonAsync("api/auth/register", userAuth, cts.Token);

                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        
                        result = JsonConvert.DeserializeObject<ApiResult<TokenResult>>(json);
                    }
                    else
                    {
                        var tempResult = JsonConvert.DeserializeObject<PlainResult>(json);
                        result = new(null, tempResult.Message, tempResult.StatusCode);
                    }
                }
                catch
                {
                    result = new(null, "Server not responds at the current moment, please try later.", -1);
                }
            }

            return result;
        }

        public static async Task<ApiResult<UserDto>> SendGetMyInfoRequestAsync(CancellationTokenSource cts)
        {
            ApiResult<UserDto> result = null;

            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                try
                {
                    var resultRaw = await httpClient.GetAsync("api/users/my");

                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<ApiResult<UserDto>>(json);
                    }
                    else
                    {
                        var tempResult = JsonConvert.DeserializeObject<PlainResult>(json);
                        result = new(null, tempResult.Message, tempResult.StatusCode);
                    }
                }
                catch
                {
                    result = new(null, "Server not responds at the current moment, please try later.", -1);
                }

                return result;
            }
        }

        public static async Task<ApiResult<UserDto>> SendUpdateMyInfo(UserDto info, CancellationTokenSource cts)
        {
            ApiResult<UserDto> result = null;

            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                try
                {
                    var resultRaw = await httpClient.PutAsJsonAsync("api/users/my", info);

                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);

                    if (resultRaw.IsSuccessStatusCode)
                    {
                        result = JsonConvert.DeserializeObject<ApiResult<UserDto>>(json);
                    }
                    else
                    {
                        var tempResult = JsonConvert.DeserializeObject<PlainResult>(json);
                        result = new(null, tempResult.Message, tempResult.StatusCode);
                    }
                }
                catch
                {
                    result = new(null, "Server not responds at the current moment, please try later.", -1);
                }

                return result;
            }
        }

        public static async Task<PlainResult> SendAddToPoolRequestAsync(CancellationTokenSource cts)
        {
            PlainResult result;

            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                try
                {
                    var resultRaw = await httpClient.PutAsync($"api/game/pool", null);

                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);
                    result = JsonConvert.DeserializeObject<PlainResult>(json);
                }
                catch
                {
                    result = new("Server not responds at the current moment, please try later.", -1);
                }

                return result;
            }
        }

        public static async Task<PlainResult> SendRemoveFromPoolRequestAsync(CancellationTokenSource cts)
        {
            PlainResult result;

            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                try
                {
                    var resultRaw = await httpClient.DeleteAsync($"api/game/pool");

                    var json = await resultRaw.Content.ReadAsStringAsync(cts.Token);
                    result = JsonConvert.DeserializeObject<PlainResult>(json);
                }
                catch
                {
                    result = new("Server not responds at the current moment, please try later.", -1);
                }

                return result;
            }
        }

        public static async IAsyncEnumerable<UserItemPool> GetPoolSnapshotAsync(CancellationTokenSource cts)
        {
            using (var httpClient = HttpClientHelper.CreateAuthorizedClient())
            {
                var resultRaw = await httpClient.GetAsync($"api/game/pool");

                using var stream = await resultRaw.Content.ReadAsStreamAsync();
                using var streamReader = new StreamReader(stream);
                using var jsonReader = new JsonTextReader(streamReader);

                var serializer = new JsonSerializer();

                while (await jsonReader.ReadAsync())
                {
                    if (jsonReader.TokenType == JsonToken.StartObject)
                    {
                        var item = serializer.Deserialize<UserItemPool>(jsonReader);
                        yield return item;
                    }
                }
            }
        }
    }
}
