using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Albums.Queries.GetAlbum
{
    internal class GetAlbumHandler : BaseHandler, IRequestHandler<GetAlbumQuery, GetAlbumViewModel>
    {
        public GetAlbumHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<GetAlbumViewModel> Handle(GetAlbumQuery request, CancellationToken cancellationToken)
        {
            var album = await dbContext.Albums
                .Where(a => a.Code == request.AlbumCode)
                .Select(a => new
                {
                    a.Code,
                    a.Name,
                    a.CoverUrl,
                    a.ReleaseDate,
                    Tracks = a.Tracks.Select(t => new
                    {
                        t.Code,
                        t.Name,
                        t.Duration,
                        Genres = t.TrackGenres.Select(g => new { g.Genre.Code, g.Genre.Name }),
                        Artists = t.ArtistTracks.Select(at => new { at.Artist.Code, at.Artist.Name })
                    }).ToList()
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (album == null)
                return null;

            var result = new GetAlbumViewModel
            {
                Code = album.Code,
                Name = album.Name,
                Cover = album.CoverUrl,
                ReleaseDate = album.ReleaseDate,
                Tracks = album.Tracks.Select(t => new TrackViewModel
                {
                    Code = t.Code.ToString(),
                    Name = t.Name,
                    Duration = t.Duration,
                    Genres = t.Genres
                        .Distinct()
                        .ToDictionary(g => g.Code, g => g.Name),
                    Artists = t.Artists
                        .Distinct()
                        .ToDictionary(a => a.Code, a => a.Name)
                }).ToList(),
                TrackCount = album.Tracks.Count,
                Duration = album.Tracks.Sum(t => t.Duration),
                Artists = album.Tracks
                    .SelectMany(t => t.Artists)
                    .Distinct()
                    .ToDictionary(a => a.Code, a => a.Name)
            };

            return result;
        }
    }
}
