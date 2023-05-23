using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nemetschek.Data.Entities;

namespace Nemetschek.Infrastructure.Data.Entities
{
    public class Genre
    {
        public Genre()
        {
            Films = new HashSet<Film>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Film> Films { get; set; }
    }
}
