using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models;

public record Project
{
    [Key]
    public int Id { get; init; }
    [Required]
    [StringLength(200, MinimumLength = 10)]
    public string Title { get; init; } = null!;

    public string Description { get; init; } = null!;
    public string Content { get; init; } = null!;
    public List<string> Skills { get; init; } = [];
}