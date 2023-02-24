using MediatR;

namespace Client.Application.Features.Identity.Commands.Login
{
    public class LoginCommand : IRequest<LoginViewModel>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string DeviceId { get; set; }
    }
}
