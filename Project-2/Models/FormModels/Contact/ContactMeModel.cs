using System.ComponentModel.DataAnnotations;

namespace Project_2.Models.FormModels.Contact;

public class ContactMeModel
{
    [Required(ErrorMessage = "THIS FIELD IS REQUIRED.")]
    [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
    public string Fullname { get; set; } = null!;

    [Required]
    [MinLength(20, ErrorMessage = "At least 20 characters required.")]
    public string Message { get; set; } =
        "Hej!\n\nVi har blivit imponerade av dina färdigheter som programmerare och tror att du skulle vara en fantastisk tillgång för vårt team.\n\nVi skulle gärna vilja komma i kontakt med dig för att diskutera potentiella möjligheter.\n\nHör av dig så snart du kan!";
}
