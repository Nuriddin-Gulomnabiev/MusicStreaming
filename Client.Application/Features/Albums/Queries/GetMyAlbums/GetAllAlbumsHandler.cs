using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Albums.Queries.GetMyAlbums
{
    internal class GetMyAlbumsHandler : BaseHandler, IRequestHandler<GetMyAlbumsQuery, List<GetMyAlbumsViewModel>>
    {
        public GetMyAlbumsHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<List<GetMyAlbumsViewModel>> Handle(GetMyAlbumsQuery request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var result = await dbContext.Albums
                .Where(a => a.ArtistAlbums.Any(aa => aa.ArtistId == userId))
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

            var albums = result.Select(a => new GetMyAlbumsViewModel
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
