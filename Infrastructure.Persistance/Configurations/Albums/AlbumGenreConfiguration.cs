using Domain.Entities.Albums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Albums
{
    public class AlbumGenreConfiguration : IEntityTypeConfiguration<AlbumGenre>
    {
        public void Configure(EntityTypeBuilder<AlbumGenre> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.AlbumId).IsRequired();
            builder.Property(p => p.GenreId).IsRequired();

            builder.HasOne(p => p.Album).WithMany(p => p.AlbumGenres).HasForeignKey(p => p.AlbumId);
            builder.HasOne(p => p.Genre).WithMany(p => p.AlbumGenres).HasForeignKey(p => p.GenreId);

            builder.HasData(
                new AlbumGenre { AlbumId = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), GenreId = new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), GenreId = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), GenreId = new Guid("2f044c88-a983-4cf5-bcc1-a5d7764507ed"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), GenreId = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), GenreId = new Guid("baa56e06-9672-4118-aee3-4098cec4581e"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), GenreId = new Guid("e2a8929f-2190-4329-bae1-83b170a3677f"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), GenreId = new Guid("ae14797c-31cd-432a-b2de-b3db95a82ab4"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), GenreId = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), Id = Guid.NewGuid() },
                new AlbumGenre { AlbumId = new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), GenreId = new Guid("8745e56f-b335-43fe-bd10-bad6bead0892"), Id = Guid.NewGuid() }
            );
        }
    }
}
