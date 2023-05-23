using Microsoft.AspNetCore.Mvc;
using Nemetschek.Core.Contracts;
using Nemetschek.Data;
using Nemetschek.Models.Film;

namespace Nemetschek.Controllers
{
    public class FilmController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService,
            ApplicationDbContext context)
        {
            _filmService = filmService;
            _context = context;
        }
        [HttpPost]
        public IActionResult Add(AddFilmViewModel model)
            
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this._filmService.Add(model);

            return Ok();
        }

        public async Task<IActionResult> Add() => this.View(new AddFilmViewModel
        {
            Genres = await this._filmService.GetGenresAsync()
        });

        public async Task<IActionResult> All(string sortOrder, int? genreId, int page = 1)
        {
            ViewData["TitleSortParam"] = string.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewData["GenreSortParam"] = sortOrder == "genre" ? "genre_desc" : "genre";

            var films = await _filmService.GetAllFilmsAsync();

            switch (sortOrder)
            {
                case "title_desc":
                    films = films.OrderByDescending(f => f.Title);
                    break;
                case "genre":
                    films = films.OrderBy(f => f.Genre.Name);
                    break;
                case "genre_desc":
                    films = films.OrderByDescending(f => f.Genre.Name);
                    break;
                default:
                    films = films.OrderBy(f => f.Title.Contains("Matrix") ? 0 : 1).ThenBy(f => f.Title);
                    break;
            }

            if (genreId.HasValue)
            {
                films = films.Where(f => f.Genre.Id == genreId.Value);
            }

            

            var genres = await _filmService.GetGenresAsync();
            ViewData["Genres"] = genres;

            int pageSize = 4; 

            var totalCount = films.Count();
            var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

            var pagedFilms = films.Skip((page - 1) * pageSize).Take(pageSize);

            var viewModel = new PagedFilmViewModel
            {
                Films = pagedFilms,
                PageIndex = page,
                TotalPages = totalPages
            };

            return View(viewModel);
        }




    }
}
