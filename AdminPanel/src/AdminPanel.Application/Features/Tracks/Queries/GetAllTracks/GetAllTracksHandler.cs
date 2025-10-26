using AdminPanel.Application.Common.Handlers;
using AdminPanel.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Application.Features.Tracks.Queries.GetAllTracks
{
    internal class GetAllTracksHandler : BaseCommandQueryHandler, IRequestHandler<GetAllTracksQuery, List<GetAllTracksViewModel>>
    {
        public GetAllTracksHandler(IAdminApplicationDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public async Task<List<GetAllTracksViewModel>> Handle(GetAllTracksQuery request, CancellationToken cancellationToken)
        {
            var skipCount = (request.Page - 1) * request.PageSize;

            var tracksQuery = dbContext.Tracks
                .Include(t => t.Album)
                .Include(t => t.TrackGenres)
                .ThenInclude(a => a.Genre)
                .Include(t => t.ArtistTracks)
                .ThenInclude(at => at.Artist)
                .AsQueryable();

            if (request.Artists != null && request.Artists.Any())
            {
                tracksQuery = tracksQuery.Where(t => t.ArtistTracks.Where(at => request.Artists.Contains(at.Artist.Code)).Any());
            }

            if (request.Genres != null && request.Genres.Any())
            {
                tracksQuery = tracksQuery.Where(t => t.TrackGenres.Where(ag => request.Genres.Contains(ag.Genre.Code)).Any());
            }

            if (!string.IsNullOrEmpty(request.Name))
            {
                tracksQuery = tracksQuery.Where(t => t.Name.ToLower().Contains(request.Name.ToLower()));
            }

            var tracks = await tracksQuery
                .Skip(skipCount)
                .Take(request.PageSize)
                .OrderBy(t => t.Name)
                .ToListAsync(cancellationToken);

            var result = mapper.Map<List<GetAllTracksViewModel>>(tracks);

            return result;
        }
    }
}
