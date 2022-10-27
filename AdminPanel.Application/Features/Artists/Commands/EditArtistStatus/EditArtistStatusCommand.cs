using MediatR;

namespace AdminPanel.Application.Features.Artists.Commands.EditArtistStatus
{
    public class EditArtistStatusCommand : IRequest<bool>
    {
        public int Code { get; set; }
        public bool Status { get; set; }

        public EditArtistStatusCommand(int code, bool status)
        {
            Code = code;
            Status = status;
        }
    }
}
