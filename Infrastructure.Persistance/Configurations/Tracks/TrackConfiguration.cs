using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Tracks
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(70).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();

            builder.HasOne(e => e.Album).WithMany(p => p.Tracks).HasForeignKey(p => p.AlbumId);

            builder.HasData(
                new Track { Id = new Guid("8366834f-0278-46e2-8142-011813bda329"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "The Explanation" },
                new Track { Id = new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Jocelyn Flores" },
                new Track { Id = new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Depression & Obsession" },
                new Track { Id = new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Everybody Dies In Their Nightmares" },
                new Track { Id = new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Revenge" },
                new Track { Id = new Guid("baace2ca-c2c0-4cee-b129-53079d696059"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Save Me" },
                new Track { Id = new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Dead Inside (Interlude)" },
                new Track { Id = new Guid("6d342342-ea26-40f4-aa92-420f3a943603"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Fuck Love feat. Trippie Redd" },
                new Track { Id = new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Carry On" },
                new Track { Id = new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Orlando" },
                new Track { Id = new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"), AlbumId = new Guid("fe024194-aad4-462a-8fbd-8dd7b4a2cd90"), Name = "Ayala (Outro)" }
            );
        }
    }
}
