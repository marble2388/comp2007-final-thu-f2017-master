using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalB.Models
{
    public class EFMoviesRepository : IMovieRepository
    {
        MovieModel db = new MovieModel();
        public IQueryable<Movie> Movies { get { return db.Movies; } }

    }
}