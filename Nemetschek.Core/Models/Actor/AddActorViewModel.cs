using System.ComponentModel.DataAnnotations;

namespace Nemetschek.Core.Models.Actor;

public class AddActorViewModel
{

    public int Id { get; set; }
    [Required]
    [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
    public string? FirstName { get; set; }
    [Required]
    [StringLength(40, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long.", MinimumLength = 1)]
    public string? LastName { get; set; }
    [Required]
    [Range(10,99, ErrorMessage = "Age must be between 10 - 99")]
    public int? Age { get; set; }
}