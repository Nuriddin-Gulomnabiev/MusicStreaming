using Client.Web.Models.Identity;
using System.Net.Http.Json;

namespace Client.Web.Services
{
    public class AuthService
    {
        private readonly HttpClient _http;
        private readonly TokenProvider _tokenProvider;

        public AuthService(HttpClient http, TokenProvider tokenProvider)
        {
            _http = http;
            _tokenProvider = tokenProvider;

            _http.BaseAddress = new Uri("https://localhost:7193");
        }

        public async Task<bool> RegisterAsync(AuthRequest request)
        {
            var response = await _http.PostAsJsonAsync("/api/v1/identity/register", request);

            var result = await response.Content.ReadFromJsonAsync<AuthResponse>();

            //if (result?.Status == true)
            //{
            //    _tokenProvider.SetToken(result.Data.AccessToken);
            //    return true;
            //}

            return false;
        }

        public async Task<bool> LoginAsync(AuthRequest request)
        {
            var response = await _http.PostAsJsonAsync("/api/v1/identity/login", request);

            var result = await response.Content.ReadFromJsonAsync<AuthResponse>();

            //if (result?.Status == true)
            //{
            //    _tokenProvider.SetToken(result.Data.AccessToken);
            //    return true;
            //}

            return false;
        }

        public async Task LogoutAsync()
        {
            await _http.PostAsync("/api/v1/identity/logout", null);
            _tokenProvider.ClearToken();
        }
    }
}
