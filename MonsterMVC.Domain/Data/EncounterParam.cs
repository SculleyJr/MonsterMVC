using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonsterMVC.Domain.Data
{
    public class EncounterParam
    {



        public int Id { get; set; }
        public int AverageLvl { get; set; }
        public char Difficulty { get; set; }
        public int NumberOfMonsters { get; set; }
        public Encounter Encounter { get; set; }



        public int GetXp(int averageLvl, char difficulty)
        {
            int xp = 100;


            Difficulty = difficulty;
            AverageLvl = averageLvl;

            if (difficulty == 'E')
            {
                if (averageLvl == 1)
                {
                    xp = 100;
                    return xp;
                }
                if (averageLvl == 2)
                {
                    xp = 200;
                    return xp;
                }
                if (averageLvl == 3)
                {
                    xp = 400;
                    return xp;
                }
                if (averageLvl == 4)
                {
                    xp = 500;
                    return xp;
                }
                if (averageLvl == 5)
                {
                    xp = 1100;
                    return xp;
                }
                if (averageLvl == 6)
                {
                    xp = 1400;
                    return xp;
                }
                if (averageLvl == 7)
                {
                    xp = 1700;
                    return xp;
                }
                if (averageLvl == 8)
                {
                    xp = 2100;
                    return xp;
                }
                if (averageLvl == 9)
                {
                    xp = 2400;
                    return xp;
                }
                if (averageLvl == 10)
                {
                    xp = 2800;
                    return xp;
                }
                if (averageLvl == 11)
                {
                    xp = 3600;
                    return xp;
                }
                if (averageLvl == 12)
                {
                    xp = 4500;
                    return xp;
                }
                if (averageLvl == 13)
                {
                    xp = 5100;
                    return xp;
                }
                if (averageLvl == 14)
                {
                    xp = 5700;
                    return xp;
                }
                if (averageLvl == 15)
                {
                    xp = 6400;
                    return xp;
                }
                if (averageLvl == 16)
                {
                    xp = 7200;
                    return xp;
                }
                if (averageLvl == 17)
                {
                    xp = 8800;
                    return xp;
                }
                if (averageLvl == 18)
                {
                    xp = 9500;
                    return xp;
                }
                if (averageLvl == 19)
                {
                    xp = 10900;
                    return xp;
                }
                if (averageLvl == 20)
                {
                    xp = 12700;
                    return xp;
                }
            }
            return xp;
        }

    
    public  IEnumerable<ActiveMonster>  CreateListOfMonsters(int xp)
        {


            var monsters = new List<ActiveMonster>();
            int[] xpArray = Enumerable.Range(1, 100).ToArray();

            {
                var tier1 = monsters.Where(x => x.Monster.Exp.Equals(xpArray));
                foreach (var monster in tier1)
                {
                    monsters.Add(monster);
                }
                return tier1;
            }

            return monsters;


        }
    }
}
