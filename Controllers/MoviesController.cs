using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;
using Vidly_2nd_try.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Vidly_2nd_try.Controllers
{

    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var generlist = _context.Genre.ToList();
            var viewmodel = new RandomMovieViewModel()
            {
                Genre = generlist
            };
            return View(viewmodel);
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }
            else
            {
                var moviedbid = _context.Movies.Single(c => c.Id == movie.Id);
                moviedbid.Name = movie.Name;
                moviedbid.ReleaseDate = movie.ReleaseDate;
                moviedbid.GenerId = movie.GenerId;
                moviedbid.DateAdded = movie.DateAdded;
                moviedbid.NumberInStock = movie.NumberInStock;
            }
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            
            return RedirectToAction("action1", "Movies");
        }
        // GET: Movies
        public ActionResult action1()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Genre = _context.Genre.ToList()
            };
            return View("New", viewModel);
        }
    }
}