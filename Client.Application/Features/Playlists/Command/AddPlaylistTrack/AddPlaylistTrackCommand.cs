using MediatR;

namespace Client.Application.Features.Playlists.Command.AddPlaylistTrack
{
    public class AddPlaylistTrackCommand : IRequest
    {
        public int TrackCode { get; set; }
        public int PlaylistCode { get; set; }
    }
}
