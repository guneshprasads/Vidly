using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Genre> Genre { get; set; }

    }
}