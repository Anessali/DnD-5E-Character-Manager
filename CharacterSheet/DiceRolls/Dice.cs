using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    class Dice
    {
        List<int> diceList = new List<int>();
        List<int> diceRolls = new List<int>();
        Random rnd = new Random();

        /// <summary>
        /// Single dice constructor
        /// </summary>
        /// <param name="num"></param>
        public Dice(int num)
        {
            diceList.Add(num);
        }

        /// <summary>
        /// Four dice constructor. Used in attribute rolls.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <param name="num4"></param>
        public Dice(int num, int num2, int num3, int num4)
        {
            diceList.Add(num);
            diceList.Add(num2);
            diceList.Add(num3);
            diceList.Add(num4);
        }

        public void Roll()
        {
            int getCount = diceList.Count;
            if (getCount > 1)
            {
                diceRolls.Add(rnd.Next(1, diceList[0]));
                diceRolls.Add(rnd.Next(1, diceList[1]));
                diceRolls.Add(rnd.Next(1, diceList[2]));
                diceRolls.Add(rnd.Next(1, diceList[3]));
                //DiceRolls.DiceMessageBox newWindow = new DiceRolls.DiceMessageBox(diceRolls, diceList);
                DiceRolls.AttributeGeneration newWindow = new DiceRolls.AttributeGeneration();
                newWindow.Show();
            }
            else
            {
                diceRolls.Add(rnd.Next(1, diceList[0]));
                DiceRolls.DiceMessageBox newWindow = new DiceRolls.DiceMessageBox(diceRolls, diceList);
                newWindow.Show();
            }
        }
    }
}
