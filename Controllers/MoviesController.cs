﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_2nd_try.Models;

namespace Vidly_2nd_try.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult action1()
        {
            var movie = new Movie() { Name = "Yash" };
            return View(movie);
        }
    }
}