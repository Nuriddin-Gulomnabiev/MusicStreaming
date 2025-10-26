using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.JwtService.Helpers;

namespace Services.Services.JwtService.Extensions
{
    public static class JwtServiceExtension
    {
        public static IServiceCollection AddJwtServices(this IServiceCollection services, IConfiguration configuration)
        {
            var JwtSettings = new JwtSettings();

            configuration.Bind(JwtSettings.Section, JwtSettings);

            services.AddSingleton(JwtSettings);
            services.AddSingleton<IJwtService, JwtService>();

            return services;
        }
    }
}
