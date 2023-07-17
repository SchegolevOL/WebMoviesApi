using Microsoft.EntityFrameworkCore;
using WebMoviesApi.Data;

namespace WebMoviesApi.Model
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider  serviceProvider)
        {
            using (var context = new WebMoviesApiContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebMoviesApiContext>>()))
            {
                if (context==null||context.Movie==null)
                {
                    throw new ArgumentNullException("");
                }
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new WebTestDB.Models.Movie
                {
                    Title="qqq",
                    ReleaseDate= DateTime.Now,
                    Gener="eeeee",
                    Price=100020

                },
                     new WebTestDB.Models.Movie
                {
                    Title="qqq",
                    ReleaseDate= DateTime.Now,
                    Gener="eeeee",
                    Price=100020

                });
            }
            
        }
    }
}
