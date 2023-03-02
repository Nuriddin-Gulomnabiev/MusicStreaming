using Services.Services.JwtService.Interfaces;

namespace Client.Application.Common.Helpers
{
    public class JwtPayload : IJwtPayload
    {
        public Guid UserId { get; set; }
        public string DeviceId { get; set; }

        public JwtPayload(Guid userId, string deviceId)
        {
            UserId = userId;
            DeviceId = deviceId;
        }
    }
}
