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
        DbSet<Admin> Admins { get; set; }
        DbSet<Album> Albums { get; set; }
        DbSet<Artist> Artists { get; set; }
        DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        DbSet<ArtistTrack> ArtistTracks { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<Track> Tracks { get; set; }
        DbSet<TrackGenre> TrackGenres { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<Playlist> Playlists { get; set; }
        DbSet<PlaylistTrack> PlaylistTracks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        void Attach<T>(T entity, CancellationToken cancellationToken = default) where T : BaseEntity;

        Task<IEnumerable<T>> QueryListAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class;

        Task<T> QueryFirstAsync<T>(string sql, CancellationToken cancellationToken = default) where T : class;

        DatabaseFacade Database { get; }
    }
}
