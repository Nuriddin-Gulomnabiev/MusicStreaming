using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities.Albums;
using Domain.Entities.Artists;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Albums.Commands.CreateAlbum
{
    internal class CreateAlbumHandler : BaseCommandQueryHandler, IRequestHandler<CreateAlbumCommand>
    {
        public CreateAlbumHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<Unit> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var album = new Album()
                {
                    Id = Guid.NewGuid(),
                    Name = request.Name,
                    ReleaseDate = request.ReleaseDate,
                    IsActive = false
                };

                dbContext.Albums.Add(album);

                await GetArtists(request.ArtistsCodes, album.Id);

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

        private async Task GetArtists(IEnumerable<int> artistCodes, Guid albumId)
        {
            artistCodes = artistCodes.Distinct();

            foreach (var artistCode in artistCodes)
            {
                var artist = await dbContext.Artists.Where(a => a.Code == artistCode).FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Исполнитель не найден");

                dbContext.ArtistAlbums.Add(new ArtistAlbum()
                {
                    Id = Guid.NewGuid(),
                    AlbumId = albumId,
                    ArtistId = artist.Id
                });
            }
        }
    }
}
