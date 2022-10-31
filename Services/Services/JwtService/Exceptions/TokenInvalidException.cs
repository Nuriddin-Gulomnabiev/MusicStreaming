namespace Services.Services.JwtService.Exceptions
{
    public class TokenInvalidException : Exception
    {
        public TokenInvalidException() : base("Неверный формат токена")
        {

        }
    }
}
