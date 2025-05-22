using AspNetApiTemplate.DTOs.Auth;
using AspNetApiTemplate.DTOs.User;

namespace AspNetApiTemplate.Services;

public interface IAuthService
{
    Task<(TokensDto Tokens, UserDto User)?> Register(RegisterRequestDto request);
    Task<(TokensDto Tokens, UserDto User)?> Login(LoginRequestDto request);
    Task<(TokensDto Tokens, UserDto User)?> RefreshTokens(string refreshToken);
}
