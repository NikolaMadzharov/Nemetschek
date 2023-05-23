namespace Nemetschek.Models.Film;

public class PagedFilmViewModel
{
    public IEnumerable<Nemetschek.Models.Film.FilmViewModel> Films { get; set; }
    public int PageIndex { get; set; }
    public int TotalPages { get; set; }
}