using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebTestDB.Models;

namespace WebMoviesApi.Data
{
    public class WebMoviesApiContext : DbContext
    {
        public WebMoviesApiContext()
        {
        }

        public WebMoviesApiContext (DbContextOptions<WebMoviesApiContext> options)
            : base(options)
        {
        }

        public DbSet<WebTestDB.Models.Movie> Movie { get; set; } = default!;
    }
}
