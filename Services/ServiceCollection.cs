using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Services.Services.FileManager;
using Services.Services.JwtService;
using Services.Services.JwtService.Exceptions;
using Services.Services.JwtService.Helpers;
using System.Text;

namespace Services
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddCommonServices(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = new JwtSettings();

            configuration.Bind(JwtSettings.Section, JwtSettings);

            services.AddSingleton(JwtSettings);
            services.AddSingleton<IFileManagerService, FileManagerService>();
            services.AddSingleton<IJwtService, JwtService>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = JwtSettings.Issuer,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSettings.Key)),
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
