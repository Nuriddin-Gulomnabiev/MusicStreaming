using AdminPanel.Application.Common.Interfaces;
using Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistance
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddAdminApplicationPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdminApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection"),
                    b => b.MigrationsAssembly(typeof(AdminApplicationDbContext).Assembly.FullName));
            });

            services.AddScoped<IAdminApplicationDbContext>(provider => provider.GetService<AdminApplicationDbContext>()!);

            return services;
        }
    }
}
