using Domain.Entities.Sessions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Sessions
{
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.DeviceId).IsRequired();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.ExpiresAt).HasColumnType("timestamp without zone").IsRequired();

            builder.HasOne(e => e.Artist).WithMany(p => p.Sessions).HasForeignKey(p => p.ArtistId);
        }
    }
}
