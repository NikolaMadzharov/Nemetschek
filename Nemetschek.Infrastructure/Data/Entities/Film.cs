using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Nemetschek.Infrastructure.Data.Entities;

namespace Nemetschek.Data.Entities;

public class Film
{
    public Film()
    {
        Actors = new HashSet<Actor>();
    }

    [Key]
    public int Id { get; set; }

    public string? Title { get; set; }
    public string? ImageUrl { get; set; }


    [ForeignKey("Genres")]
    public int? GenreId { get; set; }

    public Genre? Genre { get; set; }

    public DateTime? Premiere { get; set; }

    public ICollection<Actor> Actors { get; set; }



}