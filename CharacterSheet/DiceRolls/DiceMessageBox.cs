using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.DiceRolls
{
    public partial class DiceMessageBox : Form
    {
        List<int> rolls = new List<int>();
        List<int> maxRolls = new List<int>();
        //int roll;
        //int maxRoll;

        /// <summary>
        /// roll refers to the dice roll. maxRoll is the maximum possible;
        /// for example, a D20 has a maxRoll of 20.
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="maxRoll"></param>
        public DiceMessageBox(List<int> rolls, List<int> maxRolls)
        {
            this.Icon = CharacterSheet.Properties.Resources.d20_icon_34412_Windows;
            InitializeComponent();
            this.rolls = rolls;
            this.maxRolls = maxRolls;
            //+1 is added for random number generation
            for (int i = 0; i < maxRolls.Count; i++)
            {
                maxRolls[i] += 1;
            }
            Roll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            Roll();
        }

        private void Roll()
        {
            Random roll = new Random();
            if (rolls.Count == 4)
            {
                rolls[0] = roll.Next(1, maxRolls[0]);
                rolls[1] = roll.Next(1, maxRolls[1]);
                rolls[2] = roll.Next(1, maxRolls[2]);
                rolls[3] = roll.Next(1, maxRolls[3]);
                rolls.Sort();
                rolls.Reverse();
                lblRoll.Text = Convert.ToString(rolls[0] + rolls[1] + rolls[2]);
            }
            else
            {
                lblRoll.Text = roll.Next(1, maxRolls[0]).ToString();
            }
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (rolls.Count == 4)
            {
                MessageBox.Show($"Dice rolls: \nD6: {rolls[0]}\nD6: {rolls[1]}\nD6: {rolls[2]}\nD6: {rolls[3]}" +
                    $"\nTop 3 Total: {rolls[0] + rolls[1] + rolls[2]}");
            }
            else
            {

            }
        }
    }
}
