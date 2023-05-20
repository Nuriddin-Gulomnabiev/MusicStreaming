using Domain.Common;
using Domain.Entities.Admins;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Playlists;
using Domain.Entities.Sessions;
using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Client.Application.Common.Interfaces
{
    public interface IClientApplicationDbContext
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

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        public void Attach<T>(T entity, CancellationToken cancellationToken = default) where T : BaseEntity;

        Task<IEnumerable<T>> QueryListAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class;

        Task<T> QueryFirstAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class;

        DatabaseFacade Database { get; }
    }
}
