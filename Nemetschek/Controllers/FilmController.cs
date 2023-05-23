using Microsoft.AspNetCore.Mvc;
using Nemetschek.Core.Contracts;
using Nemetschek.Models.Film;

namespace Nemetschek.Controllers
{
    public class FilmController : Controller
    {

        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
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

    }
}
