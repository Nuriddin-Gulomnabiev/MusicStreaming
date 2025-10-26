using Client.Application.Common.Interfaces;
using Dapper;
using Domain.Common;
using Domain.Entities.Admins;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Playlists;
using Domain.Entities.Sessions;
using Domain.Entities.Tracks;
using Infrastructure.Persistance.Configurations.Admins;
using Infrastructure.Persistance.Configurations.Albums;
using Infrastructure.Persistance.Configurations.Artists;
using Infrastructure.Persistance.Configurations.Genres;
using Infrastructure.Persistance.Configurations.Playlists;
using Infrastructure.Persistance.Configurations.Sessions;
using Infrastructure.Persistance.Configurations.Tracks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Contexts
{
    public class ClientApplicationDbContext : DbContext, IClientApplicationDbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<TrackGenre> TrackGenres { get; set; }
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
            modelBuilder.ApplyConfiguration(new TrackGenreConfiguration());
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

        public void Attach<T>(T entity, CancellationToken cancellationToken = default) where T : BaseEntity
        {
            base.Set<T>().Attach(entity);
        }

        public async Task<IEnumerable<T>> QueryListAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class
        {
            var connection = Database.GetDbConnection();

            return await connection.QueryAsync<T>(new CommandDefinition(sql, cancellationToken));
        }

        public async Task<T> QueryFirstAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class
        {
            var connection = Database.GetDbConnection();

            return await connection.QueryFirstOrDefaultAsync<T>(new CommandDefinition(sql, cancellationToken));
        }
    }
}
