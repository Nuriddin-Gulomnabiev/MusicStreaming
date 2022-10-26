using Microsoft.Extensions.DependencyInjection;
using Services.Services.FileManager;

namespace Services
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddCommonServices(this IServiceCollection services)
        {
            services.AddSingleton<IFileManagerService, FileManagerService>();

            return services;
        }
    }
}
