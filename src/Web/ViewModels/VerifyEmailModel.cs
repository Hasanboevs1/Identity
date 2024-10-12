using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels;

public class VerifyEmailModel
{
    [Required(ErrorMessage = "The Email field is required.")]
    [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
    public string Email { get; set; } = string.Empty;
}
