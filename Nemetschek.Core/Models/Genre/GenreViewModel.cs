using System.ComponentModel.DataAnnotations;

namespace Nemetschek.Core.Models.Genre;

public class GenreViewModel
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }

}