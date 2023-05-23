using Nemetschek.Infrastructure.Data.Entities;

namespace Nemetschek.Models.Film;

public class FilmViewModel
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? ImageUrl { get; set; }

    public Genre? Genre { get; set; }

    public IEnumerable<Actor> Actors { get; set; }

    public DateTime? Premiere { get; set; }


}