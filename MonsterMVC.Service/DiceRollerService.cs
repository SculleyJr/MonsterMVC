using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Service
{
   public class DiceRollerService
    {
        private Random _random= new Random();
        public int DiceRoller(int numberOfDice, int diceRolled)
        {
            int max = diceRolled * numberOfDice;
            int miniumum = 1 * numberOfDice;
            int diceResult = _random.Next(miniumum, max);
            return diceResult;
        }
    }
}
