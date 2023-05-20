using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using Domain.Exceptions;
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
            var track = await dbContext.Tracks
                .Where(t => t.Code == request.Code)
                .Include(t => t.Album)
                .Include(t => t.ArtistTracks)
                .ThenInclude(at => at.Artist)
                .FirstOrDefaultAsync(cancellationToken)
                ?? throw new ResourceNotFoundException("Трек не найден");

            return mapper.Map<GetTrackViewModel>(track);
        }
    }
}
