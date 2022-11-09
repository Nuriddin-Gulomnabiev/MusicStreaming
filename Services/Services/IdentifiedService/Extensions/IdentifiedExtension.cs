using Microsoft.Extensions.DependencyInjection;

namespace Services.Services.IdentifiedService.Extensions
{
    public static class IdentifiedExtension
    {
        public static IServiceCollection AddIdentifiedServices(this IServiceCollection services)
        {
            services.AddScoped<IIdentifiedService, IdentifiedService>();

            return services;
        }
    }
}
