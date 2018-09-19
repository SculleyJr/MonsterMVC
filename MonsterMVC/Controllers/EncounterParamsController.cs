using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;
using MonsterMVC.Domain.DomainModel;
using MonsterMVC.Domain.Enums;
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
