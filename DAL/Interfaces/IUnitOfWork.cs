using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IMoviesRepository Movies { get; }
        ICategoryRepository Category { get; }
        int Complete();
    }
}
