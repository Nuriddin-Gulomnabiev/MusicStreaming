using Domain.Entities.Artists;
using MediatR;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistCommand : IRequest<Artist>
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
