using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using Nemetschek.Core.Models.Actor;
using Nemetschek.Core.Models.Genre;

namespace Nemetschek.Models.Film;

public class AddFilmViewModel
{
    public int Id { get; set; }

    [Required]

    [StringLength(30, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 3)]
    public string? Title { get; set; }

    [Required]
    public DateTime Premiere { get; set; }

    [Required]
    public string? ImageUrl { get; set; }

    [Required]
    [Display(Name = "Genres")]
    public int GenreId { get; set; }

    public IEnumerable<GenreViewModel> Genres { get; set; } = new List<GenreViewModel>();

    [Required]
    public List<AddActorViewModel> Actors { get; set; } = new List<AddActorViewModel>();


}