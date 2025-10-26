using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Services.Services.JwtService.Exceptions;
using Services.Services.JwtService.Helpers;
using System.Text;

namespace AdminPanel.Web.Common.Extensions
{
    public static class AuthorizeExtension
    {
        public static IServiceCollection AddAuthorizationAuthetication(this IServiceCollection services)
        {
            var jwtSettings = services.BuildServiceProvider().GetService<JwtSettings>();

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtSettings.Issuer,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key)),
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.FromMinutes(0)
                };
                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            throw new TokenExpiredException();
                        }
                        else if (context.Exception.GetType() != typeof(TokenExpiredException))
                        {
                            throw new TokenInvalidException();
                        }

                        return Task.CompletedTask;
                    }
                };
            });

            services.AddAuthorization();

            return services;
        }
    }
}
