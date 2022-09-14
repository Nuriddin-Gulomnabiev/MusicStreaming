using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    internal class ArtistTrackConfiguration : IEntityTypeConfiguration<ArtistTrack>
    {
        public void Configure(EntityTypeBuilder<ArtistTrack> builder)
        {
            builder.ToTable("album_genres").HasKey("id");
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.TrackId).IsRequired();
        }
    }
}
