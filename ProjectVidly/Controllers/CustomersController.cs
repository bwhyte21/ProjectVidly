using ProjectVidly.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace ProjectVidly.Controllers
{
    public class CustomersController : Controller
    {
        // DB context to access database.
        private readonly ApplicationDbContext _context;

        // Inject obj.
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        
        // Dispose of obj after use.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ViewResult Index()
        {
            // Get list of customers.
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null) { return HttpNotFound(); }

            return View(customer);
        }
    }
}