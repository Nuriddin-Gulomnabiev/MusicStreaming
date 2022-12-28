using MediatR;

namespace AdminPanel.Application.Features.Genres.Queries.GetAllGenres
{
    public class GetAllGenresQuery : IRequest<List<GetAllGenresViewModel>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Name { get; set; }
    }
}
