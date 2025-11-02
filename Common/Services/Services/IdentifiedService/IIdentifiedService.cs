using Services.Services.JwtService.Interfaces;

namespace Services.Services.IdentifiedService
{
    public interface IIdentifiedService
    {
        void SetToken(string token);
        void SetUserId(Guid userId);
        void SetPayload(IJwtPayload payload);
        string GetToken();
        Guid GetUserId();
        T GetPayload<T>() where T : IJwtPayload;
    }
}
