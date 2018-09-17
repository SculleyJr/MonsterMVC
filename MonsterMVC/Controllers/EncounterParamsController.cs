using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;
using MonsterMVC.Domain.DomainModel;
using MonsterMVC.Domain.Enums;

namespace MonsterMVC.Controllers
{
    public class EncounterParamsController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();

        public ICollection<MonsterDataModel> GetListOfMonstersByExperience(int experienceParameter)
        {
            var monsterDataModelController = new MonsterDataModelsController();
            var monsterList = monsterDataModelController.SearchMonstersXP(experienceParameter);
            return monsterList;
        }

        public int GetExperienceAllowanceForEncounter(int averagePlayerLevel, char encounterDifficulty)
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
                    xp = 300;
                }
                if (averagePlayerLevel == 4)
                {
                    xp = 500;
                }
                if (averagePlayerLevel == 5)
                {
                    xp = 1000;
                }
                if (averagePlayerLevel == 6)
                {
                    xp = 1200;
                }
                if (averagePlayerLevel == 7)
                {
                    xp = 1400;
                }
                if (averagePlayerLevel == 8)
                {
                    xp = 1800;
                }
                if (averagePlayerLevel == 9)
                {
                    xp = 2200;
                }
                if (averagePlayerLevel == 10)
                {
                    xp = 2400;
                }
                if (averagePlayerLevel == 11)
                {
                    xp = 3200;
                }
                if (averagePlayerLevel == 12)
                {
                    xp = 4000;
                }
                if (averagePlayerLevel == 13)
                {
                    xp = 4400;
                }
                if (averagePlayerLevel == 14)
                {
                    xp = 5000;
                }
                if (averagePlayerLevel == 15)
                {
                    xp = 5600;
                }
                if (averagePlayerLevel == 16)
                {
                    xp = 6400;
                }
                if (averagePlayerLevel == 17)
                {
                    xp = 8000;
                }
                if (averagePlayerLevel == 18)
                {
                    xp = 8400;
                }
                if (averagePlayerLevel == 19)
                {
                    xp = 9600;
                }
                if (averagePlayerLevel == 20)
                {
                    xp = 11200;
                }
            }

            return xp;
        }

        public float GetAverageMonsterExperience(int totalExperienceAllowance, int numberOfMonstersInEncounter)
        {
            var individualMonsterExperience =  totalExperienceAllowance / numberOfMonstersInEncounter;
            return individualMonsterExperience;
        }

        public int GetExperienceSearchParameter(int numberOfMonsters, int experienceAllowance)
        {
            var expectedEnum = (experienceAllowance/numberOfMonsters);
            var comparisonEnum = MonsterExperienceValuesEnum.Tier1;
            while (expectedEnum >(int)comparisonEnum)
            {
                comparisonEnum++;
            }

            var maxPotentialTierDivision = expectedEnum%(int)comparisonEnum;
            comparisonEnum++;
            var minPotentialTierDivision = expectedEnum % (int) comparisonEnum;

            if (minPotentialTierDivision < maxPotentialTierDivision)
            {
                expectedEnum = (int)comparisonEnum;
            }
            else
            {
                comparisonEnum++;
                expectedEnum = (int) comparisonEnum;
            }

            return expectedEnum;

        }

    }
}
