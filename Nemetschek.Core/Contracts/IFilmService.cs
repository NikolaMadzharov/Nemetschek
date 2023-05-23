using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nemetschek.Core.Models.Genre;
using Nemetschek.Data.Entities;
using Nemetschek.Models.Film;

namespace Nemetschek.Core.Contracts
{
    public interface IFilmService
    {
        public void Add(AddFilmViewModel model);

        Task<IEnumerable<GenreViewModel>> GetGenresAsync();


    }
}
