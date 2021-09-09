using System.Web.Mvc;
using System.Web.UI;

namespace ProjectVidly.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //[OutputCache(Duration = 50, Location = OutputCacheLocation.Server, VaryByParam = "*")] // Use only when performance in page is slow.
        [OutputCache(Duration = 0, VaryByParam = "*", NoStore = true)] // To disable caching.
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}