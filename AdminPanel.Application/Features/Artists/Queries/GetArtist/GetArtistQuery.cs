using MediatR;

namespace AdminPanel.Application.Features.Artists.Queries.GetArtist
{
    public class GetArtistQuery : IRequest<GetArtistViewModel>
    {
        public int Code { get; private set; }

        public GetArtistQuery(int code)
        {
            Code = code;
        }
    }
}
