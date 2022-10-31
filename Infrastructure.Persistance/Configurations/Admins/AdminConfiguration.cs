using Domain.Entities.Admins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Admins
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.MiddleName).HasMaxLength(50);
            builder.Property(p => p.Login).HasMaxLength(25).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(30).IsRequired();

            builder.HasData(new Admin()
            {
                Id = Guid.NewGuid(),
                FirstName = "Админ",
                LastName = "Админов",
                MiddleName = "Админович",
                Login = "admin",
                Password = "admin"
            });
        }
    }
}
