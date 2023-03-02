using MediatR;

namespace Client.Application.Features.Identity.Commands.RefreshToken
{
    public class RefreshTokenCommand : IRequest<RefreshTokenViewModel>
    {
    }
}
