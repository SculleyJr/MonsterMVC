using MonsterMVC.Domain.Data;
using System.Web.Mvc;

namespace MonsterMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search()
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

        public ActionResult Encounter(Encounter encounter)
        {
            return View(encounter);
        }
    }
}