using BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMoviesRepository : IGenericRepository<Movies>
    {
        IEnumerable<Movies> GetPopularMovies(int count);
    }
}
