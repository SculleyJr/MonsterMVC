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

        public ActionResult TestResultView(int numberOfPlayers, int numberOfMonsters, int averagePlayerLevel, char encounterDifficulty)
        {


          var monsters = _generateRandomEncounterService.GenerateRandomEncounter(numberOfPlayers, numberOfMonsters, averagePlayerLevel, encounterDifficulty);

            return View(monsters);
        }


    }
}
