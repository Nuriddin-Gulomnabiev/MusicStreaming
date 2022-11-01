using Domain.Exceptions;
using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Tracks.Queries.GetTrack
{
    internal class GetTrackHandler : BaseCommandQueryHandler, IRequestHandler<GetTrackQuery, GetTrackViewModel>
    {
        public GetTrackHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<GetTrackViewModel> Handle(GetTrackQuery request, CancellationToken cancellationToken)
        {
            var track = await dbContext.Tracks.Where(t => t.Code == request.Code).Include(t => t.Album).FirstOrDefaultAsync(cancellationToken)
                ?? throw new ResourceNotFoundException("Трек не найден");

            var res = mapper.Map<GetTrackViewModel>(track);

            var artists = await dbContext.ArtistTracks.Where(at => at.TrackId == track.Id).Select(a => a.Artist).ToListAsync();

            if (!artists.Any())
                throw new ResourceNotFoundException($"Исполнители трека {track.Code} не найдены");

            res.Artists = artists.ToDictionary(a => a.Code, a => a.Name);

            return res;
        }
    }
}
