using MediatR;

namespace Client.Application.Features.Identity.Commands.Register
{
    public class RegisterCommand : IRequest<RegisterViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DeviceId { get; set; }
    }
}
