using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    public class ArtistAlbumConfiguration : IEntityTypeConfiguration<ArtistAlbum>
    {
        public void Configure(EntityTypeBuilder<ArtistAlbum> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.AlbumId).IsRequired();

            builder.HasOne(p => p.Artist).WithMany(p => p.ArtistAlbums).HasForeignKey(p => p.ArtistId);
            builder.HasOne(p => p.Album).WithMany(p => p.ArtistAlbums).HasForeignKey(p => p.AlbumId);

            builder.HasData(
                new ArtistAlbum { AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("30965a2d-b2eb-448b-bedb-56e56215f76f") },
                new ArtistAlbum { AlbumId = new Guid("c7b12644-83a9-4ccd-8418-808b11d9755e"), ArtistId = new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"), Id = new Guid("86e9eb76-1f31-40b1-a655-6b7d6860a7bd") },
                new ArtistAlbum { AlbumId = new Guid("62e05eec-dfed-462d-abfe-7489534fad8b"), ArtistId = new Guid("03810320-12e9-435f-9d8b-473572074360"), Id = new Guid("87cb0a2e-63f3-491c-b164-eac43dd743f4") },
                new ArtistAlbum { AlbumId = new Guid("f7c43f96-79e4-4244-b21b-8ac476e54495"), ArtistId = new Guid("d3179697-703d-4ee8-998d-7674119309a5"), Id = new Guid("994a42cd-1c68-4fdb-b2b1-f0e9f4ee44a5") }
            );
        }
    }
}
