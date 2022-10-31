using Microsoft.IdentityModel.Tokens;
using Services.Services.JwtService.Exceptions;
using Services.Services.JwtService.Helpers;
using Services.Services.JwtService.ModelResponses;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services.Services.JwtService
{
    internal class JwtService : IJwtService
    {
        private readonly JwtSettings JwtSettings;

        private readonly SymmetricSecurityKey Key;

        public JwtService(JwtSettings jwtSettings)
        {
            JwtSettings = jwtSettings;

            Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.Key));
        }

        public Tokens CreateToken(Guid userId)
        {
            var claims = new[]
            {
                new Claim("data", userId.ToString()),
            };

            var signingCredentials = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256Signature);

            var accessToken = WriteToken(claims, signingCredentials, JwtSettings.AccessExpiration);
            var refreshToken = WriteToken(claims, signingCredentials, JwtSettings.RefreshExpiration);

            return new Tokens(accessToken, refreshToken);
        }

        public ClaimsPrincipal ValidateToken(string token)
        {
            try
            {
                var validationParameters = new TokenValidationParameters()
                {
                    ValidateLifetime = true,

                    ValidateIssuer = true,
                    ValidIssuer = JwtSettings.Issuer,

                    ValidateAudience = false,

                    ValidateIssuerSigningKey = true,

                    IssuerSigningKey = Key,

                    ClockSkew = TimeSpan.FromMinutes(0)
                };

                return new JwtSecurityTokenHandler().ValidateToken(token, validationParameters, out _);
            }
            catch (SecurityTokenExpiredException)
            {
                throw new TokenExpiredException();
            }
            catch (Exception)
            {
                throw new TokenInvalidException();
            }
        }

        private string WriteToken(Claim[] claims, SigningCredentials signingCredentials, int tokenExpire)
        {
            var jwt = new JwtSecurityToken(
                            issuer: JwtSettings.Issuer,
                            audience: JwtSettings.Audience,
                            claims: claims,
                            expires: DateTime.Now.AddMinutes(tokenExpire),
                            signingCredentials: signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}
