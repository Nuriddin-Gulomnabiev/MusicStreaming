using MediatR;

namespace AdminPanel.Application.Features.Artists.Commands.CreateArtist
{
    public class CreateArtistCommand : IRequest
    {
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
