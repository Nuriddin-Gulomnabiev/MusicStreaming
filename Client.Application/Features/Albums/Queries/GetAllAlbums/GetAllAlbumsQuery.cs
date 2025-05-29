using MediatR;

namespace Client.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQuery : IRequest<List<GetAllAlbumsViewModel>>
    {
        public int ArtistCode { get; set; }
    }
}
