using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;
using Vidly_2nd_try.ViewModels;

namespace Vidly_2nd_try.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult action1()
        {
            var movie = new Movie() { Name = "Kantara" };
            var customers = new List<Customer>() 
            {
                new Customer{ Name = "Yash"},
                new Customer{ Name = "Rajkumar"}
            };
            var viewmodel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customer = customers
            };
            return View(viewmodel);
        }
    }
}