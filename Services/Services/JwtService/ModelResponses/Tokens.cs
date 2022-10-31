﻿namespace Services.Services.JwtService.ModelResponses
{
    public class Tokens
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public Tokens(string accessToken, string refreshToken)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
        }
    }
}
