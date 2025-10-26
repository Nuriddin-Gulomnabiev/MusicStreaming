using MediatR;

namespace Client.Application.Features.Playlists.Query.GetPlaylist
{
    public class GetPlaylistQuery : IRequest<GetPlaylistViewModel>
    {
        public int PlaylistCode { get; set; }

        public GetPlaylistQuery(int playlistCode)
        {
            PlaylistCode = playlistCode;
        }
    }
}
