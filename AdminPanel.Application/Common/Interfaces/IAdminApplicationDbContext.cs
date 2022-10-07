using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Common.Interfaces
{
    public interface IAdminApplicationDbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumGenre> AlbumGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
