using AdminPanel.Application.Common.Interfaces;
using Infrastructure.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistance
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddAdminApplicationPersistence(this IServiceCollection services)
        {
            services.AddDbContext<AdminApplicationDbContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5433;Database=musics;Username=postgres;Password=P!kn!k12",
                    b => b.MigrationsAssembly(typeof(AdminApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IAdminApplicationDbContext>(provider => provider.GetService<AdminApplicationDbContext>()!);

            return services;
        }
    }
}
