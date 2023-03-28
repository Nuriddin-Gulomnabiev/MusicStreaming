using Domain.Entities.Admins;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Client.Application.Common.Interfaces;
using Domain.Entities.Sessions;
using Domain.Entities.Playlists;
using Infrastructure.Persistance.Configurations.Admins;
using Infrastructure.Persistance.Configurations.Albums;
using Infrastructure.Persistance.Configurations.Artists;
using Infrastructure.Persistance.Configurations.Genres;
using Infrastructure.Persistance.Configurations.Playlists;
using Infrastructure.Persistance.Configurations.Sessions;
using Infrastructure.Persistance.Configurations.Tracks;
using Domain.Common;

namespace Infrastructure.Persistance.Contexts
{
    public class ClientApplicationDbContext : DbContext, IClientApplicationDbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumGenre> AlbumGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<PlaylistTrack> PlaylistTracks { get; set; }

        public ClientApplicationDbContext(DbContextOptions<ClientApplicationDbContext> options) : base(options)
        {
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
            modelBuilder.ApplyConfiguration(new SessionConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistConfiguration());
            modelBuilder.ApplyConfiguration(new PlaylistTrackConfiguration());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateChangedProperties<T>(T entity, CancellationToken cancellationToken = default) where T : BaseEntity
        {
            Set<T>().Attach(entity);

            await base.SaveChangesAsync(cancellationToken);
        }
    }
}
