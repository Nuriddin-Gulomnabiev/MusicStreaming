using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Albums.Queries.GetAllAlbums
{
    internal class GetAllAlbumsHandler : BaseHandler, IRequestHandler<GetAllAlbumsQuery, List<GetAllAlbumsViewModel>>
    {
        public GetAllAlbumsHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<List<GetAllAlbumsViewModel>> Handle(GetAllAlbumsQuery request, CancellationToken cancellationToken)
        {
            var query = dbContext.Albums
                .AsQueryable();

            if (request.ArtistCode > 0)
            {
                query = query.Where(a => a.Tracks.Any(t => t.ArtistTracks.Any(at => at.Artist.Code == request.ArtistCode)));
            }

            var result = await query
                .Select(a => new
                {
                    a.Code,
                    a.Name,
                    Cover = a.CoverUrl,
                    a.ReleaseDate,
                    Tracks = a.Tracks.Select(t => new
                    {
                        t.Duration,
                        ArtistCodes = t.ArtistTracks.Select(at => new { at.Artist.Code, at.Artist.Name })
                    }).ToList()
                })
                .ToListAsync(cancellationToken);

            var albums = result.Select(a => new GetAllAlbumsViewModel
            {
                Code = a.Code,
                Name = a.Name,
                Cover = a.Cover,
                ReleaseDate = a.ReleaseDate,
                TrackCount = a.Tracks.Count,
                Duration = a.Tracks.Sum(t => t.Duration),
                Artists = a.Tracks
                    .SelectMany(t => t.ArtistCodes)
                    .GroupBy(ar => ar.Code)
                    .Select(g => g.First())
                    .ToDictionary(ar => ar.Code, ar => ar.Name)
            }).ToList();

            return albums;

        }
    }
}
