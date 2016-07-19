using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //db object
        private ApplicationDbContext _context;

        //Constructor
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //Override the dispose methode, properly dispose the db object
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Movies")]

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        [Route("Movies/Details/{id}")]

        public ActionResult Details(int? id)
        {
            var movies = _context.Movies.ToList();

            foreach (var movie in movies)
            {
                if (movie.Id == id)
                {
                    return View(movie);
                }
            }

            return Content("Not found.");
        }

    }
}