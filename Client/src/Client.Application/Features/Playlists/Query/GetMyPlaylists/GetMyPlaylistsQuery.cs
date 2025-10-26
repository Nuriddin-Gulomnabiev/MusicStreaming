using MediatR;

namespace Client.Application.Features.Playlists.Query.GetMyPlaylists
{
    public class GetMyPlaylistsQuery : IRequest<List<GetMyPlaylistsViewModel>>
    {
    }
}
