using Domain.Entities.Admins;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;
using Client.Application.Common.Interfaces;
using Domain.Entities.Sessions;

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

        public ClientApplicationDbContext(DbContextOptions<ClientApplicationDbContext> options) : base(options)
        {
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
