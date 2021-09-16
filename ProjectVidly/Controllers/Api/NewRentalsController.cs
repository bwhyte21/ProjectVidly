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
            // Using single, so if any malicious users toss in a fake id, they get a vague response in return.
            var customer = _context.Customers.Single(c => c.Id == newRental.CustomerId);

            // This style translates the clause into a Sql statement that uses the IN clause.
            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id));

            
            foreach (var movie in movies)
            {
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