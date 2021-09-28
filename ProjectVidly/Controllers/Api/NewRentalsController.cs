using ProjectVidly.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ProjectVidly.Models;

namespace ProjectVidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        #region Dependency Injection

        private readonly ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        #endregion

        

        /// <summary>
        /// Takes a new rental dto.
        /// The HttpPost attribute is used as we will be creating new objects for video rentals.
        /// </summary>
        /// <param name="newRental"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            // If any malicious users toss in a fake id, they will receive a BadRequest response in return.
            //var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId); // Useful for public api, we will use the latter since this is an internal api.
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            // This style translates the clause into a Sql statement that uses the IN clause.
            /*
             * example:
             * SELECT *
             * FROM Movies
             * WHERE Id IN (1, 2, 3)
             */
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

            // One or more of the movies were not loaded..
            // Also to prevent malicious calls.
            if (movies.Count != newRental.MovieIds.Count)
            {
                return BadRequest("One or more Movie Ids are invalid.");
            }
            
            foreach (var movie in movies)
            {
                // Check number count.
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }

                // Decrease number of movies available per movie rented.
                movie.NumberAvailable--;

                // ForEach movie, we create a rental object.
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                // Add it to context.
                _context.Rentals.Add(rental);
            }

            // Save changes.
            _context.SaveChanges();

            return Ok();
        }
    }
}