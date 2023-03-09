using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly MoviesDbContext _context;

        public UnitOfWork(MoviesDbContext context)
        {
            _context = context;
            Movies = new MoviesRepository(_context);
            Category = new CategoryRepository(_context);

        }

        public IMoviesRepository Movies { get; private set; }
        public ICategoryRepository Category { get; private set; }



        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
