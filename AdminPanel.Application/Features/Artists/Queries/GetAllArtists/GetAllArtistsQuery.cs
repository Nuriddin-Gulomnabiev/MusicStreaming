using MediatR;

namespace AdminPanel.Application.Features.Artists.Queries.GetAllArtists
{
    public class GetAllArtistsQuery : IRequest<IEnumerable<GetAllArtistsViewModel>>
    {
    }
}
