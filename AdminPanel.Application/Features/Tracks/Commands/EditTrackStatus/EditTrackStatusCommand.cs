using MediatR;

namespace AdminPanel.Application.Features.Tracks.Commands.EditTrackStatus
{
    public class EditTrackStatusCommand : IRequest<bool>
    {
        public int Code { get; set; }
        public bool Status { get; set; }

        public EditTrackStatusCommand(int code, bool status)
        {
            Code = code;
            Status = status;
        }
    }
}
