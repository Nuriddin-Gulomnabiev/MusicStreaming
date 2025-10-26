using Domain.Entities.Playlists;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistance.Configurations.Playlists
{
    public class PlaylistConfiguration : IEntityTypeConfiguration<Playlist>
    {
        public void Configure(EntityTypeBuilder<Playlist> builder)
        {
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.Code).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.IsPublic).IsRequired();
            builder.Property(p => p.LastUpdatedAt).HasColumnType("date");

            builder.HasMany(p => p.PlaylistTracks).WithOne(p => p.Playlist).HasForeignKey(p => p.PlaylistId);
            builder.HasOne(p => p.CreatedByArtist).WithMany(p => p.Playlists).HasForeignKey(p => p.CreatedByArtistId);

            builder.HasData(
                new Playlist()
                {
                    Id = new Guid("b0e7bcbd-945d-453e-a9cc-e54d397a9fe9"),
                    CreatedByArtistId = new Guid("c878736d-da07-4401-ab27-2743d4e035c5"),
                    IsActive = true,
                    Title = "Лучшее XXXtentacion",
                    IsPublic = true
                }
            );
        }
    }
}
