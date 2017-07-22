using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly.Dice
{
    public class DiceRoller : IDiceRoller
    {
        private IEnumerable<IDie> dice;

        public DiceRoller(IEnumerable<IDie> dice)
        {
            this.dice = dice;
        }

        public Int32 RollDice()
        {
            return dice.Sum(d => d.Roll());
        }
    }
}
