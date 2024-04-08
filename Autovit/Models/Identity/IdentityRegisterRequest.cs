using System.ComponentModel.DataAnnotations;

namespace Autovit.Models.Identity;

public class IdentityRegisterRequest
{
    [MaxLength(30)]
    [Required]
    public string Username { get; set; }
    [MaxLength(60)]
    [Required]
    [MinLength(6)]
    public string Password { get; set; }
    [Required]
    [MaxLength(30)]
    [EmailAddress]
    public string Email { get; set; }
    public string? PhoneNumber { get; set; }
}