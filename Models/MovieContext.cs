using Microsoft.EntityFrameworkCore;
using Mission06_CalebHanssen.Models;

namespace Mission06_CalebHanssen.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) //Constructor
        { 
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, CategoryName = "Family" },
                    new Category { CategoryId = 2, CategoryName = "Action/Adventure" },
                    new Category { CategoryId = 3, CategoryName = "Drama" },
                    new Category { CategoryId = 4, CategoryName = "Television" },
                    new Category { CategoryId = 5, CategoryName = "VHS" },
                    new Category { CategoryId = 6, CategoryName = "Horror/Suspense" },
                    new Category { CategoryId = 7, CategoryName = "Comedy" },
                    new Category { CategoryId = 8, CategoryName = "Miscellaneous" }

                );
        }
    }
}

