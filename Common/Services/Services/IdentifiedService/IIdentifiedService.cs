using Services.Services.JwtService.Interfaces;

namespace Services.Services.IdentifiedService
{
    public interface IIdentifiedService
    {
        public void SetToken(string token);
        public void SetUserId(Guid userId);
        public void SetPayload(IJwtPayload payload);
        public string GetToken();
        public Guid GetUserId();
        T GetPayload<T>() where T : IJwtPayload;
    }
}
