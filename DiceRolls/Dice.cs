using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Dice
    {
        int num;
        Random rnd = new Random();
        public Dice(int num)
        {
            this.num = num;
        }

        public void Roll()
        {
            int diceRoll = rnd.Next(1, num);
            DiceRolls.DiceMessageBox newWindow = new DiceRolls.DiceMessageBox(diceRoll, num);
            newWindow.Show();
        }
    }
}
