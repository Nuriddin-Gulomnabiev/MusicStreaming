using MediatR;

namespace AdminPanel.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQuery : IRequest<List<GetAllAlbumsViewModel>>
    {
        public string Name { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public ICollection<int> Artists { get; set; }
        public ICollection<int> Genres { get; set; }
    }
}
