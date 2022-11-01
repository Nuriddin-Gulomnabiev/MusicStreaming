using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.FileManager.Helpers;

namespace Services.Services.FileManager.Extensions
{
    public static class FileManagerExtension
    {
        public static IServiceCollection AddFileManagerServices(this IServiceCollection services, IConfiguration configuration)
        {
            var FileManagerSettings = new FileManagerSettings();

            configuration.Bind(FileManagerSettings.Section, FileManagerSettings);

            services.AddSingleton(FileManagerSettings);
            services.AddSingleton<IFileManagerService, FileManagerService>();

            return services;
        }
    }
}
