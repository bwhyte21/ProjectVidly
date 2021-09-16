using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ProjectVidly.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false) { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // Customer DbSet
        public DbSet<Customer> Customers { get; set; }

        // Movie DbSet
        public DbSet<Movie> Movies { get; set; }

        // MembershipType DbSet
        public DbSet<MembershipType> MembershipTypes { get; set; }

        // Genre DbSet
        public DbSet<Genre> Genres { get; set; }

        // Movie Rentals DbSet
        public DbSet<Rental> Rentals { get; set; }
    }
}