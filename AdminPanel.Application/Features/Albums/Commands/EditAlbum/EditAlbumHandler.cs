using AdminPanel.Application.Common.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Albums.Commands.EditAlbum
{
    internal class EditAlbumHandler : BaseCommandQueryHandler, IRequestHandler<EditAlbumCommand, bool>
    {
        public EditAlbumHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<bool> Handle(EditAlbumCommand request, CancellationToken cancellationToken)
        {
            var album = await dbContext.Albums.Where(a => a.Id == request.Id && a.Code == request.Code).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                await UpdateArtists(request.ArtistsCodes, album.Id);
                await UpdateGenres(request.GenresCodes, album.Id);

                album.Name = request.Name;
                album.IsActive = request.IsActive;
                album.ReleaseDate = request.ReleaseDate;

                dbContext.Albums.Update(album);
                await dbContext.SaveChangesAsync();

                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();

                throw;
            }

            return true;
        }

        private async Task UpdateArtists(IEnumerable<int> artistCodes, Guid albumId)
        {
            var oldArtists = await dbContext.ArtistAlbums
                    .Where(a => a.AlbumId == albumId)
                    .Include(a => a.Artist)
                    .ToListAsync();

            var newArtistCodes = artistCodes.Distinct().ToList();

            foreach (var oldArtist in oldArtists)
            {
                if (newArtistCodes.Contains(oldArtist.Artist.Code))
                    newArtistCodes.Remove(oldArtist.Artist.Code);
                else
                    dbContext.ArtistAlbums.Remove(oldArtist);
            }

            foreach (var newArtistCode in newArtistCodes)
            {
                var newArtist = await dbContext.Artists
                    .Where(a => a.Code == newArtistCode)
                    .AsNoTracking()
                    .FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                dbContext.ArtistAlbums.Add(new ArtistAlbum()
                {
                    Id = Guid.NewGuid(),
                    ArtistId = newArtist.Id,
                    AlbumId = albumId
                });
            }
        }

        private async Task UpdateGenres(IEnumerable<int> genresCodes, Guid albumId)
        {
            var oldGenres = await dbContext.AlbumGenres
                    .Where(a => a.AlbumId == albumId)
                    .Include(a => a.Genre)
                    .ToListAsync();

            var newGenresCodes = genresCodes.Distinct().ToList();

            foreach (var oldGenre in oldGenres)
            {
                if (newGenresCodes.Contains(oldGenre.Genre.Code))
                    newGenresCodes.Remove(oldGenre.Genre.Code);
                else
                    dbContext.AlbumGenres.Remove(oldGenre);
            }

            foreach (var newArtistCode in newGenresCodes)
            {
                var newArtist = await dbContext.Artists
                    .Where(a => a.Code == newArtistCode)
                    .AsNoTracking()
                    .FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                dbContext.ArtistAlbums.Add(new ArtistAlbum()
                {
                    Id = Guid.NewGuid(),
                    ArtistId = newArtist.Id,
                    AlbumId = albumId
                });
            }
        }
    }
}
