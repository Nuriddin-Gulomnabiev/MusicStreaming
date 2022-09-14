using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    public class ArtistAlbumConfiguration : IEntityTypeConfiguration<ArtistAlbum>
    {
        public void Configure(EntityTypeBuilder<ArtistAlbum> builder)
        {
            builder.ToTable("album_genres").HasKey("id");
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.AlbumId).IsRequired();
        }
    }
}
