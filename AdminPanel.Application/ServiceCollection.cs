using MediatR;
using FluentValidation;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using AdminPanel.Application.Common.Behaviours;
using Services;

namespace AdminPanel.Application
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddAdminApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddCommonServices();

            return services;
        }
    }
}
