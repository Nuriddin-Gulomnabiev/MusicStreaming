namespace Services.Services.IdentifiedService
{
    public interface IIdentifiedService
    {
        public void SetToken(string token);
        public void SetUserId(Guid userId);
        public string GetToken();
        public Guid GetUserId();
    }
}
