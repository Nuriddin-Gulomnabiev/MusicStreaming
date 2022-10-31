namespace Services.Services.JwtService.Helpers
{
    internal class JwtSettings
    {
        public string Section { get; } = "Authorization";

        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }

        public int AccessExpiration { get; set; }
        public int RefreshExpiration { get; set; }
    }
}
