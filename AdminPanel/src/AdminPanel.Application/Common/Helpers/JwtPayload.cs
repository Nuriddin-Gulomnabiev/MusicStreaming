using Services.Services.JwtService.Interfaces;

namespace AdminPanel.Application.Common.Helpers
{
    public class JwtPayload : IJwtPayload
    {
        public Guid UserId { get; set; }

        public JwtPayload(Guid userId)
        {
            UserId = userId;
        }
    }
}
