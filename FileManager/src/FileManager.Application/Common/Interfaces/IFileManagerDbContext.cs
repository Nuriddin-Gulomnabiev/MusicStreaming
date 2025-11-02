using Domain.Entities.Albums;
using Domain.Entities.Tracks;
using Microsoft.EntityFrameworkCore;

namespace FileManager.Application.Common.Interfaces
{
    public interface IFileManagerDbContext
    {
        DbSet<Album> Albums { get; set; }
        DbSet<Track> Tracks { get; set; }
    }
}
