using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalB.Models;

namespace FinalB.Controllers
{
    //[Authorize]
    public class MoviesController : Controller
    {
        private IMovieRepository db;

        // default constructor using Entity Framework Repo
        public MoviesController()
        {
            this.db = new EFMoviesRepository();
        }

        // testing constructor using Mock Repo
        public MoviesController(IMovieRepository mock)
        {
            this.db = mock;
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = db.Movies.Include(m => m.Studio);
            return View(movies.ToList());
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Movie movie = db.Movies.SingleOrDefault(m => m.MovieID == id);
            if (movie == null)
            {
                return View("Error");
            }
            return View(movie);
        }

        
    }
}
