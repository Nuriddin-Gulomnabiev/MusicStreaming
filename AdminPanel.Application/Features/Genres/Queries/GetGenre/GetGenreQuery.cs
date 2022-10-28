using MediatR;

namespace AdminPanel.Application.Features.Genres.Queries.GetGenre
{
    public class GetGenreQuery : IRequest<GetGenreViewModel>
    {
        public int Code { get; set; }

        public GetGenreQuery(int code)
        {
            Code = code;
        }
    }
}
