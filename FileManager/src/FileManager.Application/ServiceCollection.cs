using FileManager.Application.Common.Behaviours;
using FileManager.Application.Common.Helpers;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FileManager.Application
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddFileManagerApplication(this IServiceCollection services, IConfiguration configuration, string rootPath)
        {
            var AllowedContentTypes = new AllowedContentTypes();

            configuration.Bind(AllowedContentTypes.Section, AllowedContentTypes);

            services.AddSingleton(AllowedContentTypes);
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddSingleton(new DirectoryPathSettings(rootPath));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}
