using MediatR;

namespace Client.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumQuery : IRequest<GetAlbumViewModel>
    {
        public int AlbumCode { get; set; }
    }
}
