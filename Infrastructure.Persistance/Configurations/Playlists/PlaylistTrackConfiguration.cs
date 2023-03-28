using Domain.Entities.Playlists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Playlists
{
    public class PlaylistTrackConfiguration : IEntityTypeConfiguration<PlaylistTrack>
    {
        public void Configure(EntityTypeBuilder<PlaylistTrack> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.TrackId).HasMaxLength(50).IsRequired();

            builder.HasOne(p => p.Track)
                   .WithMany(p => p.PlaylistTracks)
                   .HasForeignKey(p => p.TrackId);

            var data = GenerateData();

            builder.HasData(data);
        }

        private static List<PlaylistTrack> GenerateData()
        {
            var result = new List<PlaylistTrack>();

            var playlistTracksIds = new List<Guid>()
            {
                new Guid("162609a2-ce5d-4cb7-b808-bf1acf903852"),
                new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"),
                new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"),
                new Guid("8d8f7b01-a8a0-4655-9c40-82be57c9fcdd"),
                new Guid("fcfad4ad-50a5-4d37-9f1a-22f1386aeb8f"),
                new Guid("64b041da-e512-4484-8d9e-2843822a700a"),
                new Guid("f0a4aae8-c51c-4b7f-abb5-b99e2135ed6a"),
            };

            var tracksIds = new List<Guid>()
            {
                new Guid("8366834f-0278-46e2-8142-011813bda329"),
                new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"),
                new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"),
            };

            for (int i = 0; i < tracksIds.Count; i++)
            {
                var playlistTrack = new PlaylistTrack()
                {
                    Id = playlistTracksIds[i],
                    TrackId = tracksIds[i],
                    PlaylistId = new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9")
                };

                if (i < tracksIds.Count - 1)
                    playlistTrack.NextPlaylistTrackId = playlistTracksIds[i + 1];

                result.Add(playlistTrack);
            }

            result.Reverse();

            return result;
        }
    }
}
