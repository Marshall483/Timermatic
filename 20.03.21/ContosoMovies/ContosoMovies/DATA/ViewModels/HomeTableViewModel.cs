using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoMovies.Models;

namespace ContosoMovies.DATA.ViewModels
{
    public class HomeTableViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
