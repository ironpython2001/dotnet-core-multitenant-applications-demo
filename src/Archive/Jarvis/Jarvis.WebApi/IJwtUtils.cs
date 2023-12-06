using Jarvis.DTOs;

namespace Jarvis.WebApi;

public interface IJwtUtils
{
    public string GenerateJwtToken(User user);
    public int? ValidateJwtToken(string? token);
}
