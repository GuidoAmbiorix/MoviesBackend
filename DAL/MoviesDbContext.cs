using BAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}