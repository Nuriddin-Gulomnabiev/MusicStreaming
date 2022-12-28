using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Artists;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities.Albums;

namespace AdminPanel.Application.Features.Albums.Commands.EditAlbum
{
    internal class EditAlbumHandler : BaseCommandQueryHandler, IRequestHandler<EditAlbumCommand>
    {
        public EditAlbumHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(EditAlbumCommand request, CancellationToken cancellationToken)
        {
            var album = await dbContext.Albums
                .Where(a => a.Id == request.Id && a.Code == request.Code)
                .Include(a => a.AlbumGenres)
                .ThenInclude(ag => ag.Genre)
                .Include(a => a.ArtistAlbums)
                .ThenInclude(aa => aa.Artist)
                .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Альбом не найден");

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                await UpdateArtists(request.ArtistsCodes, album);
                await UpdateGenres(request.GenresCodes, album);

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

            return Unit.Value;
        }

        private async Task UpdateArtists(IEnumerable<int> artistCodes, Album album)
        {
            var oldArtists = album.ArtistAlbums;

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
                    AlbumId = album.Id
                });
            }
        }

        private async Task UpdateGenres(IEnumerable<int> genresCodes, Album album)
        {
            var oldGenres = album.AlbumGenres;

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
                    AlbumId = album.Id
                });
            }
        }
    }
}
