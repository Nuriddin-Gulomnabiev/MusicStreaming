using MediatR;

namespace AdminPanel.Application.Features.Identity.Commands.Login
{
    public class LoginCommand : IRequest<LoginViewModel>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
