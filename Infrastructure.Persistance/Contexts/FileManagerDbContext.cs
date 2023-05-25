using Domain.Entities.Albums;
using Domain.Entities.Tracks;
using FileManager.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Contexts
{
    public class FileManagerDbContext : DbContext, IFileManagerDbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public FileManagerDbContext(DbContextOptions<FileManagerDbContext> options) : base(options)
        {
        }
    }
}
