using AutoMapper;
using AutoMapper.QueryableExtensions;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    internal class GetPlaylistHandler : BaseHandler, IRequestHandler<GetPlaylistQuery, GetPlaylistViewModel>
    {
        private readonly ILogger logger;

        public GetPlaylistHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService, ILoggerFactory loggerFactory) : base(dbContext, mapper, identifiedService)
        {
            logger = loggerFactory.CreateLogger(GetType().Name);
        }

        public async Task<GetPlaylistViewModel> Handle(GetPlaylistQuery request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists
                .Where(p => p.Code == request.PlaylistCode &&
                           (p.IsPublic == true || p.CreatedByArtistId == userId))
                .AsNoTracking()
                .ProjectTo<GetPlaylistViewModel>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            playlist.Tracks = await GetTracks(playlist.Code);

            return playlist;
        }

        private async Task<List<GetPlaylistViewModel.TrackViewModel>> GetTracks(int code)
        {
            var sql = $@"
                SELECT
                    ROW_NUMBER() OVER (ORDER BY pt.""Position"") AS Position,
                    t.""Code"" AS Code,
                    t.""Name"" AS Name,
                    json_agg(json_build_object('code', a.""Code"", 'name', a.""Name"")) AS ArtistsJson
                FROM ""PlaylistTracks"" pt
                    INNER JOIN ""Tracks"" t ON pt.""TrackId"" = t.""Id""
                    INNER JOIN ""Playlists"" p ON pt.""PlaylistId"" = p.""Id""
                    LEFT JOIN ""ArtistTracks"" at ON t.""Id"" = at.""TrackId""
                    LEFT JOIN ""Artists"" a ON at.""ArtistId"" = a.""Id""
                    WHERE p.""Code"" = '{code}'
                GROUP BY
                    pt.""Position"", t.""Code"", t.""Name""
                ORDER BY
                    pt.""Position""";

            var tracks = await dbContext.QueryListAsync<GetPlaylistViewModel.TrackViewModel>(sql);

            return tracks.ToList();
        }
    }
}
