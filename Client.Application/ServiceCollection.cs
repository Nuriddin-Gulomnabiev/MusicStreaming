using MediatR;
using FluentValidation;
using Client.Application.Common.Behaviours;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Services.FileManager.Extensions;
using Services.Services.IdentifiedService.Extensions;
using System.Reflection;

namespace Client.Application
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddAdminApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddIdentifiedServices();
            services.AddFileManagerServices(configuration);

            return services;
        }
    }
}
