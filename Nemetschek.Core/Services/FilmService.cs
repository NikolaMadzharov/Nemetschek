using Nemetschek.Core.Contracts;
using Nemetschek.Data;
using Nemetschek.Data.Entities;
using Nemetschek.Models.Film;

namespace Nemetschek.Core.Services;

public class FilmService:IFilmService
{
    public readonly ApplicationDbContext _context;

    public FilmService(ApplicationDbContext context )
    {
        _context = context;
    }


    public void Add(AddFilmViewModel model)
    {
        if (model == null)
        {
            throw new NullReferenceException("Film cannot be null!");
        }

        var film = new Film
        {
            Title = model.Title,
            Premiere = model.Premiere,
            ImageUrl = model.ImageUrl,
            GenreId = model.GenreId
        };

        _context.Films.AddAsync(film);
        _context.SaveChanges();

    }
}