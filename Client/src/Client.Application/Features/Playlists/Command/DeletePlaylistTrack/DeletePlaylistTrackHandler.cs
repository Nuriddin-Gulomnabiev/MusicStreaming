using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Command.DeletePlaylistTrack
{
    internal class DeletePlaylistTrackHandler : BaseHandler, IRequestHandler<DeletePlaylistTrackCommand>
    {
        public DeletePlaylistTrackHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<Unit> Handle(DeletePlaylistTrackCommand request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.CreatedByArtistId == userId && p.Code == request.PlaylistCode && p.IsActive).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            using var tran = dbContext.Database.BeginTransaction();
            try
            {
                var playlistTrack = await dbContext.PlaylistTracks.Where(p => p.PlaylistId == playlist.Id).OrderBy(o => o.Position).Skip(request.Position - 1).FirstOrDefaultAsync()
                    ?? throw new ResourceNotFoundException("Трек не найден");

                dbContext.PlaylistTracks.Remove(playlistTrack);
                await dbContext.SaveChangesAsync();

                tran.Commit();

                return Unit.Value;
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
        }
    }
}
