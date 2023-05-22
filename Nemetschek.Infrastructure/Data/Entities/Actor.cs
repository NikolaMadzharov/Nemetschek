using Nemetschek.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nemetschek.Infrastructure.Data.Entities;

public class Actor
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? Age { get; set; }

    [ForeignKey("Film")]
    public int FilmId { get; set; }

    public Film? Film { get; set; }

}