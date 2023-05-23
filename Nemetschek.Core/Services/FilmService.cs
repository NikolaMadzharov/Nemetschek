using Microsoft.EntityFrameworkCore;
using Nemetschek.Core.Contracts;
using Nemetschek.Core.Models.Genre;
using Nemetschek.Data;
using Nemetschek.Data.Entities;
using Nemetschek.Infrastructure.Data.Entities;
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
            GenreId = model.GenreId,
            Actors = new List<Actor>() 
        };

        foreach (var actorModel in model.Actors)
        {
            var actor = new Actor
            {
                FirstName = actorModel.FirstName,
                LastName = actorModel.LastName,
                Age = actorModel.Age
            };

            film.Actors.Add(actor); 
        }

        _context.Films.AddAsync(film);
        _context.SaveChanges();
    }

    public async Task<IEnumerable<GenreViewModel>> GetGenresAsync()
    {
        var filmGenres = await this._context.Genres
            .Select(x => new GenreViewModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

        return filmGenres;
    }
}