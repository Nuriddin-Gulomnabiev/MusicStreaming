using MediatR;

namespace Client.Application.Features.Albums.Queries.GetMyAlbums
{
    public class GetMyAlbumsQuery : IRequest<List<GetMyAlbumsViewModel>>
    {
    }
}
