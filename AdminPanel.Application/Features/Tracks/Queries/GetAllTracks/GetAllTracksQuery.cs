using MediatR;

namespace AdminPanel.Application.Features.Tracks.Queries.GetAllTracks
{
    public class GetAllTracksQuery : IRequest<List<GetAllTracksViewModel>>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Name { get; set; }

        public ICollection<int> Artists { get; set; }
        public ICollection<int> Genres { get; set; }
    }
}
