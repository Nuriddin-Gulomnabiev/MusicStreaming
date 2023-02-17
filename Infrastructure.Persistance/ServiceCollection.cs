using AdminPanel.Application.Common.Interfaces;
using Client.Application.Common.Interfaces;
using FileManager.Application.Common.Interfaces;
using Infrastructure.Persistance.Contexts;
using Microsoft.AspNetCore.Builder;
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

        public static IServiceCollection AddClientApplicationPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ClientApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection"))
            );

            services.AddScoped<IClientApplicationDbContext>(provider => provider.GetService<ClientApplicationDbContext>()!);

            return services;
        }

        public static IServiceCollection AddFileManagerPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FileManagerDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSqlConnection"))
            );

            services.AddScoped<IFileManagerDbContext>(provider => provider.GetService<FileManagerDbContext>());

            return services;
        }

        public static WebApplication UseAdminApplicationMigrates(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AdminApplicationDbContext>();
                db.Database.Migrate();
            }

            return app;
        }
    }
}
