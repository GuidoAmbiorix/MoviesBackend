using BAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class MoviesDbContext : IdentityDbContext<IdentityUser>
    {
        public MoviesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}