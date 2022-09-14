using Domain.Entities.Albums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Albums
{
    public class AlbumGenreConfiguration : IEntityTypeConfiguration<AlbumGenre>
    {
        public void Configure(EntityTypeBuilder<AlbumGenre> builder)
        {
            builder.ToTable("album_genres").HasKey("id");
            builder.Property(p => p.AlbumId).IsRequired();
            builder.Property(p => p.GenreId).IsRequired();
        }
    }
}
