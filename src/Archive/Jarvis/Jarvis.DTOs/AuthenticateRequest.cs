using System.ComponentModel.DataAnnotations;

namespace Jarvis.DTOs;
public class AuthenticateRequest
{
    [Required]
    public string? Username { get; set; }

    [Required]
    public string? Password { get; set; }
}
