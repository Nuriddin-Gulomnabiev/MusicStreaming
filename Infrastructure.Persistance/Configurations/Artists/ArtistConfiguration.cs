using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();

            builder.HasData(
                new Artist { Id = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Name = "XXXtentacion" },
                new Artist { Id = new Guid("a62f20f1-a42d-41cb-8c17-890cc61b4b14"), Name = "Playboi Carti" },
                new Artist { Id = new Guid("03810320-12e9-435f-9d8b-473572074360"), Name = "Lil Uzi Vert" },
                new Artist { Id = new Guid("d3179697-703d-4ee8-998d-7674119309a5"), Name = "Pi'erre Bourne" }
            );
        }
    }
}
