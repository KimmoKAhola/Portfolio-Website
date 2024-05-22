using System.ComponentModel.DataAnnotations;

namespace Project_2.Models.FormModels.Contact;

public class ContactMeModel
{
    [Required]
    [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
    public string Fullname { get; set; } = null!;

    [Required]
    [MinLength(20, ErrorMessage = "At least 20 characters required.")]
    public string Message { get; set; } =
        "Hej, du verkar verkligen vara den bästa programmeraren som inte har blivit anställd än. Vi från \"{ERT FÖRETAG}\" vill ha kontakt med dig omedelbums.";
}
