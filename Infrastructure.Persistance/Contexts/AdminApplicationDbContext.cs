using AdminPanel.Application.Common.Interfaces;
using Domain.Entities.Admins;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Tracks;
using Infrastructure.Persistance.Configurations.Admins;
using Infrastructure.Persistance.Configurations.Albums;
using Infrastructure.Persistance.Configurations.Artists;
using Infrastructure.Persistance.Configurations.Genres;
using Infrastructure.Persistance.Configurations.Tracks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Contexts
{
    public class AdminApplicationDbContext : DbContext, IAdminApplicationDbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumGenre> AlbumGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public AdminApplicationDbContext(DbContextOptions<AdminApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumGenreConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistAlbumConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistTrackConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new TrackConfiguration());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
