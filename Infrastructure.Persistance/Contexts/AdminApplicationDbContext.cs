using AdminPanel.Application.Common.Interfaces;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Entities.Genres;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Contexts
{
    public class AdminApplicationDbContext : DbContext, IAdminApplicationDbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumGenre> AlbumGenres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistAlbum> ArtistAlbums { get; set; }
        public DbSet<ArtistTrack> ArtistTracks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public AdminApplicationDbContext(DbContextOptions<AdminApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=musics;Username=postgres;Password=P!kn!k12");
        }
    }
}
