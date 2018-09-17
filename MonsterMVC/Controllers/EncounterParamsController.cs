using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;
using MonsterMVC.Domain.DomainModel;

namespace MonsterMVC.Controllers
{
    public class EncounterParamsController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();


        public ActionResult GetExperienceAllowanceForEncounter(int averagePlayerLevel, char encounterDifficulty)
        {
            int xp = 100;

            if (encounterDifficulty == 'E')
            {
                if (averagePlayerLevel == 1)
                {
                    xp = 100;
                }
                if (averagePlayerLevel == 2)
                {
                    xp = 200;
                }
                if (averagePlayerLevel == 3)
                {
                    xp = 400;
                }
                if (averagePlayerLevel == 4)
                {
                    xp = 500;
                }
                if (averagePlayerLevel == 5)
                {
                    xp = 1100;
                }
                if (averagePlayerLevel == 6)
                {
                    xp = 1400;
                }
                if (averagePlayerLevel == 7)
                {
                    xp = 1700;
                }
                if (averagePlayerLevel == 8)
                {
                    xp = 2100;
                }
                if (averagePlayerLevel == 9)
                {
                    xp = 2400;
                }
                if (averagePlayerLevel == 10)
                {
                    xp = 2800;
                }
                if (averagePlayerLevel == 11)
                {
                    xp = 3600;
                }
                if (averagePlayerLevel == 12)
                {
                    xp = 4500;
                }
                if (averagePlayerLevel == 13)
                {
                    xp = 5100;
                }
                if (averagePlayerLevel == 14)
                {
                    xp = 5700;
                }
                if (averagePlayerLevel == 15)
                {
                    xp = 6400;
                }
                if (averagePlayerLevel == 16)
                {
                    xp = 7200;
                }
                if (averagePlayerLevel == 17)
                {
                    xp = 8800;
                }
                if (averagePlayerLevel == 18)
                {
                    xp = 9500;
                }
                if (averagePlayerLevel == 19)
                {
                    xp = 10900;
                }
                if (averagePlayerLevel == 20)
                {
                    xp = 12700;
                }
            }

            return RedirectToAction("GetAverageMonsterExperience", new{totalExperienceAllowance = xp});
        }

        public ActionResult GetAverageMonsterExperience(int totalExperienceAllowance, int numberOfMonstersInEncounter)
        {
            var individualMonsterExperience =  totalExperienceAllowance / numberOfMonstersInEncounter;
            return RedirectToAction("GetTemporaryMonsters", new {individualMonsterExperience = individualMonsterExperience});
        }

        public ICollection<MonsterDataModel> GetTemporaryMonsters(int indvidualMonsterExperience, int numberOfMonsters)
        {
            //TODO: return a list of monsters as a collection to the activemonster create method in ActiveMonstersController;
        }
    }
}
