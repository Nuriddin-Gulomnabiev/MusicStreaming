using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Client.Web.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly TokenProvider _tokenProvider;

        public CustomAuthStateProvider(TokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = string.IsNullOrWhiteSpace(_tokenProvider.AccessToken)
                ? new ClaimsIdentity()
                : new ClaimsIdentity(
                [
                    new Claim(ClaimTypes.Name, "User"),
                    new Claim("access_token", _tokenProvider.AccessToken)
                ], "jwt");

            var user = new ClaimsPrincipal(identity);
            return Task.FromResult(new AuthenticationState(user));
        }

        public void NotifyAuthenticationStateChanged() =>
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
    }
}
