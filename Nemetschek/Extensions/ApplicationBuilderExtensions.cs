using Microsoft.EntityFrameworkCore;
using Nemetschek.Data;
using Nemetschek.Infrastructure.Data.Entities;

namespace Nemetschek.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDataBase(this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<ApplicationDbContext>();

            data.Database.Migrate();

            SeedGenres(data);

            return app;
        }
        private static void SeedGenres(ApplicationDbContext data)
        {
            if (data.Genres.Any())
            {
                return;
            }
            data.Genres.AddRange(new[]
            {
                new Genre{Name = "Action"},
                new Genre{Name = "Comedy"},
                new Genre{Name = "Drama"},
                new Genre{Name = "Adventure"},
            });

            data.SaveChanges();
        }


    }
}
