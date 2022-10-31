namespace Services.Services.JwtService.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException() : base("Срок токена истек")
        {
        }
    }
}
