using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Web.Models;

public class User : IdentityUser
{
    [Required]
    public string FullName { get; set; } = string.Empty;
}
