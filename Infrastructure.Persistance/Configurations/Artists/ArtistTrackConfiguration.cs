using Domain.Entities.Artists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Artists
{
    internal class ArtistTrackConfiguration : IEntityTypeConfiguration<ArtistTrack>
    {
        public void Configure(EntityTypeBuilder<ArtistTrack> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.ArtistId).IsRequired();
            builder.Property(p => p.TrackId).IsRequired();

            builder.HasOne(p => p.Artist).WithMany(p => p.ArtistTracks).HasForeignKey(p => p.ArtistId);
            builder.HasOne(p => p.Track).WithMany(p => p.ArtistTracks).HasForeignKey(p => p.TrackId);

            builder.HasData(
                new ArtistTrack { TrackId = new Guid("8366834f-0278-46e2-8142-011813bda329"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("034fe159-32db-4875-9131-6426134d2743") },
                new ArtistTrack { TrackId = new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("062c2665-7591-4c78-82da-da9fe95f2277") },
                new ArtistTrack { TrackId = new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("1227371f-f8cb-409c-ae62-9a864ce52d62") },
                new ArtistTrack { TrackId = new Guid("f0c1326b-0646-46f4-966f-c10caa9c931b"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("1d7ace2e-de9c-492a-b535-723fb24975cb") },
                new ArtistTrack { TrackId = new Guid("492f70ab-f1de-4de4-93b3-8602df66b05a"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("38d003fd-762e-410b-b93c-3b4ef2ec39ca") },
                new ArtistTrack { TrackId = new Guid("baace2ca-c2c0-4cee-b129-53079d696059"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("960c53c2-d34a-4692-9f2b-6d6fd1015868") },
                new ArtistTrack { TrackId = new Guid("84d5050b-a7b7-4c23-a2d1-93281183264a"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("983414b0-1371-4327-bd66-684afc8e3d05") },
                new ArtistTrack { TrackId = new Guid("6d342342-ea26-40f4-aa92-420f3a943603"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("d033186f-8ab5-435e-9874-5238e141b148") },
                new ArtistTrack { TrackId = new Guid("8e22b0a3-063e-40ae-976e-5b06f762c8ce"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("dc4036b5-d7ef-4788-8b33-e21b42374005") },
                new ArtistTrack { TrackId = new Guid("77b75ed9-e6d2-4d47-84c9-58af10e455c1"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("dc96bf29-f981-4cfe-9777-a459d0ab69db") },
                new ArtistTrack { TrackId = new Guid("7fdfa190-66d6-43be-b2af-dbbd45052828"), ArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"), Id = new Guid("de175c65-a3a6-4204-a1b2-318abe039cee") }
            );
        }
    }
}
