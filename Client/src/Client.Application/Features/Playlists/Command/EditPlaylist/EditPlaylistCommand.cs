using MediatR;
using Microsoft.AspNetCore.Http;

namespace Client.Application.Features.Playlists.Command.EditPlaylist
{
    public class EditPlaylistCommand : IRequest
    {
        public int PlaylistCode { get; set; }
        public string? Title { get; set; }
        public bool? IsPublic { get; set; }
        public IFormFile Cover { get; set; } // TODO: обработка обложки плейлиста
    }
}
