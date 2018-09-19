using System.Web.Mvc;
using MonsterMVC.Service;

namespace MonsterMVC.Controllers
{
   

    public class EncounterParamsController : Controller
    {
       private GenerateRandomEncounterService _generateRandomEncounterService = new GenerateRandomEncounterService();
       

        public ActionResult TestView()
        {
            return View();
        }

        public ActionResult TestResultView(int numberOfMonsters, int averagePlayerLevel)
        {


          var monsters = _generateRandomEncounterService.GenerateRandomEncounter(numberOfMonsters, averagePlayerLevel);

            return View(monsters);
        }


    }
}
