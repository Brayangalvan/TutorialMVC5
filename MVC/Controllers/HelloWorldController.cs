using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}