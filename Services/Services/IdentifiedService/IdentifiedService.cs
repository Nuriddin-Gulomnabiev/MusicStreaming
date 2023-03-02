using Services.Services.JwtService.Interfaces;

namespace Services.Services.IdentifiedService
{
    public class IdentifiedService : IIdentifiedService
    {
        private Guid UserId;
        private string Token;
        private IJwtPayload payload;

        public string GetToken()
        {
            return Token;
        }

        public Guid GetUserId()
        {
            return UserId;
        }

        public T GetPayload<T>() where T : IJwtPayload
        {
            return (T)payload;
        }

        public void SetPayload(IJwtPayload payload)
        {
            this.payload = payload;
        }

        public void SetToken(string token)
        {
            Token = token;
        }

        public void SetUserId(Guid userId)
        {
            UserId = userId;
        }
    }
}
