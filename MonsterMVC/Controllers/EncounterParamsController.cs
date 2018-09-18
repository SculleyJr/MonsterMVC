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

            while (!ExperienceTotalIsInTargetRange(monsterStack, experienceAllowance))
            {
                var stackTotalExp = CalculateStackTotalExp(monsterStack);

                PopMonsterFromStack(monsterStack);

                var alteredExperienceParameter = AlterSearchParameter(experienceParameter, stackTotalExp, experienceAllowance);

                var temporaryMonsterList = GetListOfMonstersByExperience(alteredExperienceParameter).ToList();

                PushMonsterToStack(monsterStack, temporaryMonsterList[GetRandomNumber(temporaryMonsterList.Count)]);

            }

            return monsterStack;
        }

        public int AlterSearchParameter(int experienceParameter, int stackTotalExp, int experienceAllowance )
        {
            var comparisonEnum = MonsterExperienceValuesEnum.Tier1;
            while (experienceParameter !=(int)comparisonEnum)
            {
                comparisonEnum++;
            }

            if (stackTotalExp > experienceAllowance)
            {
                comparisonEnum--;
            }
            else
            {
                comparisonEnum++;
            }

            var alteredSearchParameter = (int)comparisonEnum;

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

        public float GetAverageMonsterExperience(int totalExperienceAllowance, int numberOfMonstersInEncounter)
        {
            var individualMonsterExperience =  totalExperienceAllowance / numberOfMonstersInEncounter;
            return individualMonsterExperience;
        }

        public int GetExperienceSearchParameter(int numberOfMonsters, int experienceAllowance)
        {
            var expectedEnum = (int)GetAverageMonsterExperience(experienceAllowance, numberOfMonsters);
            var comparisonEnum = MonsterExperienceValuesEnum.Tier1;
            int i;
            foreach (MonsterExperienceValuesEnum value in (int[])Enum.GetValues(typeof(MonsterExperienceValuesEnum)))
            {
               
               
                if (expectedEnum > (int)value)
                {
                    continue;
                }

                if (expectedEnum <= (int) value)
                {
                    return (int) value;
                }
               
            }
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
