using MediatR;

namespace Client.Application.Features.Playlists.Command.CreatePlaylist
{
    public class CreatePlaylistCommand : IRequest
    {
        public string Title { get; set; }
    }
}
