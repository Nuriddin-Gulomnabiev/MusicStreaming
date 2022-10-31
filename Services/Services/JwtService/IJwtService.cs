using Services.Services.JwtService.Exceptions;
using Services.Services.JwtService.ModelResponses;
using System.Security.Claims;

namespace Services.Services.JwtService
{
    public interface IJwtService
    {
        Tokens CreateToken(Guid userId);

        /// <summary>
        /// Валидация токена
        /// </summary>
        /// <param name="token">Токен</param>
        /// <returns></returns>
        /// <exception cref="TokenExpiredException">Срок токена истек</exception>
        /// <exception cref="TokenInvalidException">Неверный формат токена</exception>
        ClaimsPrincipal ValidateToken(string token);
    }
}
