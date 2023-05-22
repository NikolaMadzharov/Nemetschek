using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using Nemetschek.Core.Models.Genre;

namespace Nemetschek.Models.Film;

public class AddFilmViewModel
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }

    [Required]
    public DateTime Premiere { get; set; }

    [Required]
    [Display(Name = "ImageUrl")]
    public string? ImageUrl { get; set; }

    [Required]
    [Display(Name = "Genres")]
    public int GenreId { get; set; }

    public IEnumerable<GenreViewModel> Genres { get; set; }

}