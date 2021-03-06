﻿using System;
using System.Collections.Generic;
using System.Linq;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;

namespace MonsterMVC.Service
{
    public class GenerateRandomEncounterService
    {
        private Random _randomGenerator = new Random();

        private MonsterDbContext db = new MonsterDbContext();

        public ICollection<MonsterDataModel> GenerateRandomEncounter(int numberOfPlayers, int numberOfMonsters, int averagePlayerLevel, char encounterDifficulty)
        {
            var monsters = GenerateStackOfMonsterDataModels(numberOfPlayers, numberOfMonsters, averagePlayerLevel, encounterDifficulty);

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

        public Stack<MonsterDataModel> GenerateStackOfMonsterDataModels(int numberOfPlayers, int numberOfMonsters, int averagePlayerLevel, char encounterDificulty)

        {
            var monsterStack = CreateMonsterStack();
            var experienceAllowance = GetExperienceAllowanceForEncounter(numberOfPlayers, averagePlayerLevel, encounterDificulty);
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
            int number = _randomGenerator.Next(1, range);
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

        public IList<MonsterDataModel> GetListOfMonstersByExperience(int experienceParameter)
        {
            var monsterExp = db.Monsters.Where(x => x.Exp.Equals(experienceParameter));
            return monsterExp.ToList();
        }

        public int GetExperienceAllowanceForEncounter(int numberOfPlayers, int averagePlayerLevel, char encounterDifficulty)
        {
           
            int xp;
            {
                if (averagePlayerLevel == 1)
                {
                    xp = 25;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 2)
                {
                    xp = 50;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 3)
                {
                    xp = 75;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;

                }
                if (averagePlayerLevel == 4)
                {
                    xp = 125;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 5)
                {
                    xp = 250;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 6)
                {
                    xp = 300;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 7)
                {
                    xp = 350;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 8)
                {
                    xp = 450;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 9)
                {
                    xp = 550;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 10)
                {
                    xp = 600;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 11)
                {
                    xp = 800;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 12)
                {
                    xp = 1000;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 13)
                {
                    xp = 1100;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 14)
                {
                    xp = 1250;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 15)
                {
                    xp = 1400;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 16)
                {
                    xp = 1600;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 17)
                {
                    xp = 2000;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 18)
                {
                    xp = 2100;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 19)
                {
                    xp = 2400;
                    xp = CalculateDifficultyExperience(encounterDifficulty, xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }
                if (averagePlayerLevel == 20)
                {
                    xp = 2800;
                    xp = CalculateDifficultyExperience(encounterDifficulty,xp);
                    xp = xp * numberOfPlayers;
                    return xp;
                }


                return xp = 0;
            }

      
        }

        public int CalculateDifficultyExperience(char encounterDifficulty, int xp)
        {
           
            switch (encounterDifficulty)
            {
                case 'E':
                    return xp;
                case 'M':
                    return xp * 2;
                case 'H':
                    return xp * 3;
                case 'D':
                    return xp * 4;
                default:
                    return xp;
            }
        }

        public int GetAverageMonsterExperience(int totalExperienceAllowance, int numberOfMonstersInEncounter)
        {
            decimal individualMonsterExperience = totalExperienceAllowance / numberOfMonstersInEncounter;
            var roundedAverage = Math.Round(individualMonsterExperience, 0, MidpointRounding.AwayFromZero);
            return (int)roundedAverage;
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
                        comparisonValOne = 50000;
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


            if (comparisonValOne % averageMonsterExperience > averageMonsterExperience % comparisonValTwo)
            {
                return comparisonValTwo;
            }

            return comparisonValOne;

        }
    }
}
