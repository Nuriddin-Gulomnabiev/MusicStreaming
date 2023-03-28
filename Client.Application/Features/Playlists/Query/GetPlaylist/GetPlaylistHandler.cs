using AutoMapper;
using Client.Application.Common.Handlers;
using Client.Application.Common.Interfaces;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Services.Services.IdentifiedService;

namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    internal class GetPlaylistHandler : BaseCommandQueryHandler, IRequestHandler<GetPlaylistQuery, GetPlaylistViewModel>
    {
        public GetPlaylistHandler(IClientApplicationDbContext dbContext, IMapper mapper, IIdentifiedService identifiedService) : base(dbContext, mapper, identifiedService)
        {
        }

        public async Task<GetPlaylistViewModel> Handle(GetPlaylistQuery request, CancellationToken cancellationToken)
        {
            var userId = identifiedService.GetUserId();

            var playlist = await dbContext.Playlists.Where(p => p.Code == request.PlaylistCode && p.IsPublic).FirstOrDefaultAsync()
                ?? throw new ResourceNotFoundException("Плейлист не найден");

            if (playlist.CreatedByArtistId != userId && playlist.IsPublic == false)
                throw new ResourceNotFoundException("Плейлист не найден");

            var tracks = await dbContext.Playlists
                .Where(p => p.Id == playlist.Id)
                .SelectMany(p => p.PlaylistTracks)
                .OrderBy(pt => pt.NextPlaylistTrackId)
                .Select(pt => pt.Track)
                .ToListAsync(cancellationToken);

            var playlistViewModel = new GetPlaylistViewModel()
            {
                Tracks = new List<GetPlaylistViewModel.TrackViewModel>()
            };

            foreach (var track in tracks)
            {
                playlistViewModel.Tracks.Add(new GetPlaylistViewModel.TrackViewModel() { Code = track.Code, Name = track.Name });
            }

            return playlistViewModel;
        }
    }
}
