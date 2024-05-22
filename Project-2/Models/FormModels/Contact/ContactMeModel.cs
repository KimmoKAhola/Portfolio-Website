using System.ComponentModel.DataAnnotations;

namespace Project_2.Models.FormModels.Contact;

public class ContactMeModel
{
    [Required]
    [StringLength(2, ErrorMessage = "Please enter at least 2 characters.")]
    public string FirstName { get; init; } = null!;

    [Required]
    [StringLength(2, ErrorMessage = "Please enter at least 2 characters.")]
    public string Surname { get; init; } = null!;

    [Required]
    [EmailAddress]
    public string Email { get; init; } = null!;

    [Required]
    [Compare("Email")]
    public string ConfirmEmail { get; init; } = null!;

    [Required]
    [StringLength(20, ErrorMessage = "Please enter at least 20 characters.")]
    public string Message { get; init; } =
        "Hej, du verkar verkligen vara den bästa programmeraren som inte har blivit anställd än. Vi från \"{ERT FÖRETAG}\" vill ha kontakt med dig omedelbums.";
}
