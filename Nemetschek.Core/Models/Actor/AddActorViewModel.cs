using System.ComponentModel.DataAnnotations;

namespace Nemetschek.Core.Models.Actor;

public class AddActorViewModel
{

    public int Id { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public int? Age { get; set; }
}