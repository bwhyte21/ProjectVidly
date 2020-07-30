using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectVidly.Models;
using ProjectVidly.ViewModels;

namespace ProjectVidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }


        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Gantz!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        // Get list of movies.
        private static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Gantz!" },
                new Movie { Id = 2, Name = "A Silent Voice" }
            };
        }
        
    }
}