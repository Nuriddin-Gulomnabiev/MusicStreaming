using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Tracks
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.ToTable("tracks").HasKey("id");
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(70).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
