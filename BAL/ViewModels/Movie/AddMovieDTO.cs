using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.ViewModels.Movie
{
    public class AddMovieDTO
    {
        public string Description { get; set; } = string.Empty;
        public int? IdCategory { get; set; }
    }
}
