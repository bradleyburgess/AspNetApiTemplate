using AspNetApiTemplate.DTOs.User;

namespace AspNetApiTemplate.DTOs.Auth;

public class AuthResponseDto
{
    public string AccessToken { get; set; } = string.Empty;
    public string? RefreshToken { get; set; } = string.Empty;
    public UserDto User { get; set; } = default!;
}
