using System.ComponentModel.DataAnnotations;

namespace ProjectAPI.Models;

public class GithubProjectViewModel
{
    [Required]
    [StringLength(200, MinimumLength = 10)]
    public string Title { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string Content { get; init; } = null!;
    public List<string> Skills { get; init; } = [];
    public Uri ProjectUrl { get; init; } = null!;
    public Uri ImageUrl { get; init; } = null!;
}
