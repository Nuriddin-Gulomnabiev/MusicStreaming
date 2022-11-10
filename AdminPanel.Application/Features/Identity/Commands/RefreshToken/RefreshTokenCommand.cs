using MediatR;

namespace AdminPanel.Application.Features.Identity.Commands.RefreshToken
{
    public class RefreshTokenCommand : IRequest<RefreshTokenViewModel>
    {
    }
}
