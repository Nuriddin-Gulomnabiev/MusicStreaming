namespace Services.Services.IdentifiedService
{
    public class IdentifiedService : IIdentifiedService
    {
        private Guid UserId;
        private string Token;

        public string GetToken()
        {
            return Token;
        }

        public Guid GetUserId()
        {
            return UserId;
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
