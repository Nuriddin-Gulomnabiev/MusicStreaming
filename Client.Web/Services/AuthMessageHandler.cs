using System.Net.Http.Headers;

namespace Client.Web.Services
{
    public class AuthMessageHandler : HttpClientHandler
    {
        private readonly TokenProvider _tokenProvider;

        public AuthMessageHandler(TokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(_tokenProvider.AccessToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _tokenProvider.AccessToken);
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
