using Domain.Entities.Albums;
using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Application.Common.Interfaces
{
    public interface IFileManagerDbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
    }
}
