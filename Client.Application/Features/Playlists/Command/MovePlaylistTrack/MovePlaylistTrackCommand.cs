using MediatR;

namespace Client.Application.Features.Playlists.Command.MovePlaylistTrack
{
    public class MovePlaylistTrackCommand : IRequest
    {
        public int PlaylistCode { get; set; }
        public int FromPosition { get; set; }
        public int ToPosition { get; set; }
    }
}
