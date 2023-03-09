using BAL.Models;
using BAL.Repositories;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MoviesRepository : GenericRepository<Movies>, IMoviesRepository
    {
        public MoviesRepository(MoviesDbContext context) : base(context)
        {
        }

        public IEnumerable<Movies> GetPopularMovies(int count)
        {
            return _context.Movies.OrderByDescending(m => m.Id).Take(count).ToList();

        }
    }
}
