using MediatR;

namespace AdminPanel.Application.Features.Admins.Commands.Login
{
    public class LoginCommand : IRequest<LoginViewModel>
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
