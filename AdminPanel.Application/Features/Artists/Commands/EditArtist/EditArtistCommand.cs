using MediatR;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtist
{
    public class EditArtistCommand : IRequest
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
