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
        "Hej! Vi har blivit imponerade av dina färdigheter som programmerare och tror att du skulle vara en fantastisk tillgång för vårt team på \"{ERT FÖRETAG}\". Vi skulle gärna vilja komma i kontakt med dig för att diskutera potentiella möjligheter. Hör av dig så snart du kan!";
}
