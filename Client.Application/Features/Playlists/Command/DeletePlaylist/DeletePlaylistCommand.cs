using MediatR;

namespace Client.Application.Features.Playlists.Command.DeletePlaylist
{
    public class DeletePlaylistCommand : IRequest
    {
        public int PlaylistCode { get; set; }
    }
}
