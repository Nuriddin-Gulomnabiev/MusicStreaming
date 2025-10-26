using MediatR;

namespace Client.Application.Features.Playlists.Command.DeletePlaylistTrack
{
    public class DeletePlaylistTrackCommand : IRequest
    {
        public int Position { get; set; }
        public int PlaylistCode { get; set; }
    }
}
