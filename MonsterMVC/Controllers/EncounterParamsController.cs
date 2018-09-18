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

namespace MonsterMVC.Controllers
{
   

    public class EncounterParamsController : Controller
    {

        private Random _randomGenerator = new Random();

        public ActionResult TestView()
        {
            return View();
        }

        public ActionResult TestResultView(int numberOfMonsters, int averagePlayerLevel)
        {


          var monsters =  GenerateRandomEncounter(numberOfMonsters, averagePlayerLevel);

            return View(monsters);
        }



        private MonsterDbContext db = new MonsterDbContext();

        public ICollection<MonsterDataModel> GenerateRandomEncounter(int numberOfMonsters, int averagePlayerLevel)
        {
            var monsters = GenerateStackOfMonsterDataModels(numberOfMonsters, averagePlayerLevel);

            var monsterList = ConvertMonsterStackToCollection(monsters);

            return monsterList;
        }

        public ICollection<MonsterDataModel> ConvertMonsterStackToCollection(Stack<MonsterDataModel> monsterStack)
        {
            var monsterCollection = new List<MonsterDataModel>();

            foreach (var monster in monsterStack)
            {
                monsterCollection.Add(monster);
            }

            return monsterCollection;
        }

        public Stack<MonsterDataModel> GenerateStackOfMonsterDataModels(int numberOfMonsters, int averagePlayerLevel)
        {
            var monsterStack = CreateMonsterStack();

            var experienceAllowance = GetExperienceAllowanceForEncounter(averagePlayerLevel);

            var experienceParameter = GetExperienceSearchParameter(numberOfMonsters, experienceAllowance);

            AddMonstersToStack(numberOfMonsters, monsterStack, experienceParameter);

            if (!ExperienceTotalIsInTargetRange(monsterStack, experienceAllowance))
            {
                var stackTotalExp = CalculateStackTotalExp(monsterStack);

                PopMonsterFromStack(monsterStack);

                var alteredExperienceParameter = AlterSearchParameter(experienceParameter, stackTotalExp, experienceAllowance);

                var temporaryMonsterList = GetListOfMonstersByExperience(alteredExperienceParameter).ToList();

                PushMonsterToStack(monsterStack, temporaryMonsterList[GetRandomNumber(temporaryMonsterList.Count)]);

            }

            return monsterStack;
        }

        public int AlterSearchParameter(int experienceParameter, int stackTotalExp, int experienceAllowance)
        {
            int alteredSearchParameter = 0;
            if (stackTotalExp < experienceAllowance)
            {
                switch (experienceParameter)
                {
                    case 0:
                        alteredSearchParameter = 10;
                        break;
                    case 10:
                        alteredSearchParameter = 25;
                        break;
                    case 25:
                        alteredSearchParameter = 50;
                        break;
                    case 50:
                        alteredSearchParameter = 100;
                        break;
                    case 100:
                        alteredSearchParameter = 200;
                        break;
                    case 200:
                        alteredSearchParameter = 450;
                        break;
                    case 450:
                        alteredSearchParameter = 700;
                        break;
                    case 700:
                        alteredSearchParameter = 1100;
                        break;
                    case 1100:
                        alteredSearchParameter = 1800;
                        break;
                    case 1800:
                        alteredSearchParameter = 2300;
                        break;
                    case 2300:
                        alteredSearchParameter = 2900;
                        break;
                    case 2900:
                        alteredSearchParameter = 3900;
                        break;
                    case 3900:
                        alteredSearchParameter = 5000;
                        break;
                    case 5000:
                        alteredSearchParameter = 5900;
                        break;
                    case 5900:
                        alteredSearchParameter = 7200;
                        break;
                    case 7200:
                        alteredSearchParameter = 11500;
                        break;
                    case 11500:
                        alteredSearchParameter = 13000;
                        break;
                    case 13000:
                        alteredSearchParameter = 15000;
                        break;
                    case 15000:
                        alteredSearchParameter = 18000;
                        break;
                    case 18000:
                        alteredSearchParameter = 20000;
                        break;
                    case 20000:
                        alteredSearchParameter = 22000;
                        break;
                    case 22000:
                        alteredSearchParameter = 25000;
                        break;
                    case 25000:
                        alteredSearchParameter = 33000;
                        break;
                    case 33000:
                        alteredSearchParameter = 41000;
                        break;
                    case 41000:
                        alteredSearchParameter = 50000;
                        break;
                    case 50000:
                        alteredSearchParameter = 62000;
                        break;
                    case 62000:
                        alteredSearchParameter = 75000;
                        break;
                    case 75000:
                        alteredSearchParameter = 90000;
                        break;
                    case 90000:
                        alteredSearchParameter = 105000;
                        break;
                    case 105000:
                        alteredSearchParameter = 120000;
                        break;
                    case 120000:
                        alteredSearchParameter = 135000;
                        break;
                    case 135000:
                        alteredSearchParameter = 155000;
                        break;
                }
            }

            if (stackTotalExp > experienceAllowance)
            {
                switch (experienceParameter)
                {
                    case 155000:
                        alteredSearchParameter = 135000;
                        break;
                    case 135000:
                        alteredSearchParameter = 120000;
                        break;
                    case 120000:
                        alteredSearchParameter = 105000;
                        break;
                    case 105000:
                        alteredSearchParameter = 90000;
                        break;
                    case 90000:
                        alteredSearchParameter = 75000;
                        break;
                    case 75000:
                        alteredSearchParameter = 62000;
                        break;
                    case 62000:
                        alteredSearchParameter = 50000;
                        break;
                    case 50000:
                        alteredSearchParameter = 41000;
                        break;
                    case 41000:
                        alteredSearchParameter = 33000;
                        break;
                    case 33000:
                        alteredSearchParameter = 25000;
                        break;
                    case 25000:
                        alteredSearchParameter = 22000;
                        break;
                    case 22000:
                        alteredSearchParameter = 20000;
                        break;
                    case 20000:
                        alteredSearchParameter = 18000;
                        break;
                    case 18000:
                        alteredSearchParameter = 15000;
                        break;
                    case 15000:
                        alteredSearchParameter = 13000;
                        break;
                    case 13000:
                        alteredSearchParameter = 11500;
                        break;
                    case 11500:
                        alteredSearchParameter = 7200;
                        break;
                    case 7200:
                        alteredSearchParameter = 5900;
                        break;
                    case 5900:
                        alteredSearchParameter = 5000;
                        break;
                    case 5000:
                        alteredSearchParameter = 3900;
                        break;
                    case 3900:
                        alteredSearchParameter = 2900;
                        break;
                    case 2900:
                        alteredSearchParameter = 2300;
                        break;
                    case 2300:
                        alteredSearchParameter = 1800;
                        break;
                    case 1800:
                        alteredSearchParameter = 1100;
                        break;
                    case 1100:
                        alteredSearchParameter = 700;
                        break;
                    case 700:
                        alteredSearchParameter = 450;
                        break;
                    case 450:
                        alteredSearchParameter = 200;
                        break;
                    case 200:
                        alteredSearchParameter = 100;
                        break;
                    case 100:
                        alteredSearchParameter = 50;
                        break;
                    case 50:
                        alteredSearchParameter = 25;
                        break;
                    case 25:
                        alteredSearchParameter = 10;
                        break;
                }
            }

            return alteredSearchParameter;
        }

        public bool ExperienceTotalIsInTargetRange(Stack<MonsterDataModel> monsterStack, int encounterXpAllowance)
        {
            if (CalculateStackTotalExp(monsterStack) > (encounterXpAllowance + 100))
            {
                return false;
            }

            if (CalculateStackTotalExp(monsterStack) < (encounterXpAllowance - 100))
            {
                return false;
            }

            return true;
        }

        public void AddMonstersToStack(int numberOfMonsters, Stack<MonsterDataModel> monsterStack, int experienceParamater)
        {
            List<MonsterDataModel> monsterList = GetListOfMonstersByExperience(experienceParamater).ToList();

            for (int i = 0; i < numberOfMonsters; i++)
            {
                PushMonsterToStack(monsterStack, monsterList[GetRandomNumber(monsterList.Count)]);

            }
        }

        public void PopMonsterFromStack(Stack<MonsterDataModel> monsterStack)
        {
            monsterStack.Pop();
        }
        public void PushMonsterToStack(Stack<MonsterDataModel> monsterStack, MonsterDataModel monster)
        {
            monsterStack.Push(monster);
            System.Diagnostics.Debug.WriteLine(monster);
        }

        public Stack<MonsterDataModel> CreateMonsterStack()
        {
            var monsterStack = new Stack<MonsterDataModel>();
            return monsterStack;
        }

        public int GetRandomNumber(int range)
        {
            int number = _randomGenerator.Next(1,range);
            return number;
        }

        public int CalculateStackTotalExp(Stack<MonsterDataModel> monsters)
        {
            int expTotal = 0;
            foreach (var monster in monsters)
            {
                expTotal += monster.Exp;
            }
            return expTotal;
        }

        public ICollection<MonsterDataModel> GetListOfMonstersByExperience(int experienceParameter)
        {
            var monsterDataModelController = new MonsterDataModelsController();
            var monsterList = monsterDataModelController.SearchMonstersXP(experienceParameter);
            return monsterList;
        }

        public int GetExperienceAllowanceForEncounter(int averagePlayerLevel/*, char encounterDifficulty*/)
        {
            var encounterDifficulty = 'E';
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

        public int GetAverageMonsterExperience(int totalExperienceAllowance, int numberOfMonstersInEncounter)
        {
            decimal individualMonsterExperience =  totalExperienceAllowance / numberOfMonstersInEncounter;
            var roundedAverage = Math.Round(individualMonsterExperience, 0, MidpointRounding.AwayFromZero);
            return (int) roundedAverage;
        }

        public int GetExperienceSearchParameter(int numberOfMonsters, int experienceAllowance)
        {
            var averageMonsterExperience = GetAverageMonsterExperience(experienceAllowance, numberOfMonsters);
            var comparisonValOne = 0;
            var comparisonValTwo = 155000;

            while (comparisonValOne < averageMonsterExperience)
            {
                switch (comparisonValOne)
                {
                    case 0:
                        comparisonValOne = 10;
                        break;
                    case 10:
                        comparisonValOne = 25;
                        break;
                    case 25:
                        comparisonValOne = 50;
                        break;
                    case 50:
                        comparisonValOne = 100;
                        break;
                    case 100:
                        comparisonValOne = 200;
                        break;
                    case 200:
                        comparisonValOne = 450;
                        break;
                    case 450:
                        comparisonValOne = 700;
                        break;
                    case 700:
                        comparisonValOne = 1100;
                        break;
                    case 1100:
                        comparisonValOne = 1800;
                        break;
                    case 1800:
                        comparisonValOne = 2300;
                        break;
                    case 2300:
                        comparisonValOne = 2900;
                        break;
                    case 2900:
                        comparisonValOne = 3900;
                        break;
                    case 3900:
                        comparisonValOne = 5000;
                        break;
                    case 5000:
                        comparisonValOne = 5900;
                        break;
                    case 5900:
                        comparisonValOne = 7200;
                        break;
                    case 7200:
                        comparisonValOne = 11500;
                        break;
                    case 11500:
                        comparisonValOne = 13000;
                        break;
                    case 13000:
                        comparisonValOne = 15000;
                        break;
                    case 15000:
                        comparisonValOne = 18000;
                        break;
                    case 18000:
                        comparisonValOne = 20000;
                        break;
                    case 20000:
                        comparisonValOne = 22000;
                        break;
                    case 22000:
                        comparisonValOne = 25000;
                        break;
                    case 25000:
                        comparisonValOne = 33000;
                        break;
                    case 33000:
                        comparisonValOne = 41000;
                        break;
                    case 41000:
                        comparisonValOne =50000;
                        break;
                    case 50000:
                        comparisonValOne = 62000;
                        break;
                    case 62000:
                        comparisonValOne = 75000;
                        break;
                    case 75000:
                        comparisonValOne = 90000;
                        break;
                    case 90000:
                        comparisonValOne = 105000;
                        break;
                    case 105000:
                        comparisonValOne = 120000;
                        break;
                    case 120000:
                        comparisonValOne = 135000;
                        break;
                    case 135000:
                        comparisonValOne = 155000;
                        break;
                }
            }
            while (comparisonValTwo > averageMonsterExperience)
            {
                switch (comparisonValTwo)
                {
                    case 155000:
                        comparisonValTwo = 135000;
                        break;
                    case 135000:
                        comparisonValTwo = 120000;
                        break;
                    case 120000:
                        comparisonValTwo = 105000;
                        break;
                    case 105000:
                        comparisonValTwo = 90000;
                        break;
                    case 90000:
                        comparisonValTwo = 75000;
                        break;
                    case 75000:
                        comparisonValTwo = 62000;
                        break;
                    case 62000:
                        comparisonValTwo = 50000;
                        break;
                    case 50000:
                        comparisonValTwo = 41000;
                        break;
                    case 41000:
                        comparisonValTwo = 33000;
                        break;
                    case 33000:
                        comparisonValTwo = 25000;
                        break;
                    case 25000:
                        comparisonValTwo = 22000;
                        break;
                    case 22000:
                        comparisonValTwo = 20000;
                        break;
                    case 20000:
                        comparisonValTwo = 18000;
                        break;
                    case 18000:
                        comparisonValTwo = 15000;
                        break;
                    case 15000:
                        comparisonValTwo = 13000;
                        break;
                    case 13000:
                        comparisonValTwo = 11500;
                        break;
                    case 11500:
                        comparisonValTwo = 7200;
                        break;
                    case 7200:
                        comparisonValTwo = 5900;
                        break;
                    case 5900:
                        comparisonValTwo = 5000;
                        break;
                    case 5000:
                        comparisonValTwo = 3900;
                        break;
                    case 3900:
                        comparisonValTwo = 2900;
                        break;
                    case 2900:
                        comparisonValTwo = 2300;
                        break;
                    case 2300:
                        comparisonValTwo = 1800;
                        break;
                    case 1800:
                        comparisonValTwo = 1100;
                        break;
                    case 1100:
                        comparisonValTwo = 700;
                        break;
                    case 700:
                        comparisonValTwo = 450;
                        break;
                    case 450:
                        comparisonValTwo = 200;
                        break;
                    case 200:
                        comparisonValTwo = 100;
                        break;
                    case 100:
                        comparisonValTwo = 50;
                        break;
                    case 50:
                        comparisonValTwo = 25;
                        break;
                    case 25:
                        comparisonValTwo = 10;
                        break;
                }
            }


            if (comparisonValOne % averageMonsterExperience > averageMonsterExperience % comparisonValTwo )
            {
                return comparisonValTwo;
            }

            return comparisonValOne;

        }

    }
}
