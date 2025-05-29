using Client.Web.Services.ApiHttpService.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Client.Web.Services.ApiHttpService
{
    public class ApiHttpService
    {
        private readonly HttpClient _http;
        private readonly TokenProvider _tokenProvider;

        public ApiHttpService(HttpClient http, TokenProvider tokenProvider)
        {
            _http = http;
            _tokenProvider = tokenProvider;
            _http.BaseAddress = new Uri("https://localhost:7193");
        }

        public async Task<ApiResponse<T>> GetAsync<T>(string url)
        {
            AddAuthorizationHeader();

            var response = await _http.GetAsync(url);
            return await HandleResponse<T>(response);
        }

        public async Task<ApiResponse<T>> PostAsync<T>(string url, object data, bool anonymous = false)
        {
            if (!anonymous)
                AddAuthorizationHeader();

            var response = await _http.PostAsJsonAsync(url, data);
            return await HandleResponse<T>(response);
        }

        private void AddAuthorizationHeader()
        {
            var token = _tokenProvider.GetToken();

            if (!string.IsNullOrWhiteSpace(token))
            {
                _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }

        private async Task<ApiResponse<T>> HandleResponse<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var success = JsonConvert.DeserializeObject<SuccessWrapper<T>>(json);

                    return new ApiResponse<T>
                    {
                        Success = true,
                        Data = success.Data
                    };
                }
                catch
                {
                    return new ApiResponse<T> { Success = false, ErrorMessage = "Ошибка при десериализации успешного ответа." };
                }
            }
            else
            {
                try
                {
                    var error = JsonConvert.DeserializeObject<ErrorWrapper<T>>(json);

                    return new ApiResponse<T>
                    {
                        Success = false,
                        ErrorCode = error.Code,
                        ErrorMessage = error.Message ?? "Произошла ошибка.",
                        ValidationErrors = error.Errors
                    };
                }
                catch
                {
                    return new ApiResponse<T> { Success = false, ErrorMessage = "Не удалось распознать ошибку." };
                }
            }
        }
    }

}
