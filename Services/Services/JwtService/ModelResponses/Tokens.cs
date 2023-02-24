namespace Services.Services.JwtService.ModelResponses
{
    public class Tokens
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public DateTime AccessExpiresAt { get; set; }
        public DateTime RefreshExpiresAt { get; set; }

        public Tokens(string accessToken, string refreshToken, DateTime accessExpiresAt, DateTime refreshExpiresAt)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;

            AccessExpiresAt = accessExpiresAt;
            RefreshExpiresAt = refreshExpiresAt;
        }
    }
}
