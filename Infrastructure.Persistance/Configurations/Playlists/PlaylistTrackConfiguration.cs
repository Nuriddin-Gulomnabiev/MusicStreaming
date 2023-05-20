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
            builder.Property(p => p.Position).IsRequired().HasColumnType("double precision");

            builder.HasOne(p => p.Track)
                   .WithMany(p => p.PlaylistTracks)
                   .HasForeignKey(p => p.TrackId);

            builder.HasData(new PlaylistTrack() { Id = new Guid("162609a2-ce5d-4cb7-b808-bf1acf903852"), TrackId = new Guid("8366834f-0278-46e2-8142-011813bda329"), PlaylistId = new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), Position = 50 });
            builder.HasData(new PlaylistTrack() { Id = new Guid("2b33dd70-f22c-4186-8100-d7a2e503b454"), TrackId = new Guid("533b7e3d-9cfd-4731-8dda-a1d5a86ff80a"), PlaylistId = new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), Position = 100 });
            builder.HasData(new PlaylistTrack() { Id = new Guid("2e8395fe-912d-499c-8a7b-5c04e47f3231"), TrackId = new Guid("1afe4a9e-7121-4b34-89a6-8db6e0b6ddad"), PlaylistId = new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"), Position = 150 });
        }
    }
}
