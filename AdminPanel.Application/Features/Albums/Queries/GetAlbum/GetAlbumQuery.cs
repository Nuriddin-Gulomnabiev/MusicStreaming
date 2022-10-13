using MediatR;

namespace AdminPanel.Application.Features.Albums.Queries.GetAlbum
{
    public class GetAlbumQuery : IRequest<GetAlbumViewModel>
    {
        public int Code { get; private set; }

        public GetAlbumQuery(int code)
        {
            Code = code;
        }
    }
}
