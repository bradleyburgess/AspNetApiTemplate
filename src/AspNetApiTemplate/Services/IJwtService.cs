using AspNetApiTemplate.Models;

namespace AspNetApiTemplate.Services;

public interface IJwtService
{
    string GenerateAccessToken(User user);
    string GenerateRefreshToken(int size = 64);
}
