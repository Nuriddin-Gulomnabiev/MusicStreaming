using Domain.Entities.Albums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Albums
{
    public class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ReleaseDate).HasColumnType("date").IsRequired();

            builder.HasData(
                new Album { Id = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "17", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), Name = "Whole Lotta Red", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), Name = "RED & WHITE", ReleaseDate = new DateTime(2020, 1, 1) },
                new Album { Id = new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), Name = "Life Of Pi'erre 5", ReleaseDate = new DateTime(2020, 1, 1) }
            );
        }
    }
}
