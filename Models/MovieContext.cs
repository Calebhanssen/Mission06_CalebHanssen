using Microsoft.EntityFrameworkCore;

namespace Mission06_CalebHanssen.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) //Constructor
        { 
        }

        public DbSet<Movie> Applications { get; set; }
    }
}
