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
    public partial class AttributeGeneration : Form
    {
        List<int[]> rolls = new List<int[]>();
        string details = "";

        public AttributeGeneration()
        {
            InitializeComponent();
            Roll();
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            Roll();
        }

        private void Roll()
        {
            //List of Arrays holds dice rolls and the sum of top 3
            List<int[]> rolls = new List<int[]>();
            Random roll = new Random();

            //Calculates dice rolls
            for (int x = 0; x < 6; x++)
            {
                rolls.Add(new int[5]);
                rolls[x][0] = roll.Next(1, 7);
                rolls[x][1] = roll.Next(1, 7);
                rolls[x][2] = roll.Next(1, 7);
                rolls[x][3] = roll.Next(1, 7);
                rolls[x][4] = 0;
                Array.Sort(rolls[x]);
                Array.Reverse(rolls[x]);
                rolls[x][4] = rolls[x][0] + rolls[x][1] + rolls[x][2];
            }
            this.rolls = rolls;

            lblRoll1.Text = rolls[0][4].ToString();
            lblRoll2.Text = rolls[1][4].ToString();
            lblRoll3.Text = rolls[2][4].ToString();
            lblRoll4.Text = rolls[3][4].ToString();
            lblRoll5.Text = rolls[4][4].ToString();
            lblRoll6.Text = rolls[5][4].ToString();

            //Adds dice roll information to details
            details = "Roll 1\tRoll 2\tRoll 3\tRoll 4\tRoll 5\tRoll 6\n";

            details += $"{rolls[0][0]}\t{rolls[1][0]}\t{rolls[2][0]}\t{rolls[3][0]}\t{rolls[4][0]}\t{rolls[5][0]}\n" +
                       $"{rolls[0][1]}\t{rolls[1][1]}\t{rolls[2][1]}\t{rolls[3][1]}\t{rolls[4][1]}\t{rolls[5][1]}\n" +
                       $"{rolls[0][2]}\t{rolls[1][2]}\t{rolls[2][2]}\t{rolls[3][2]}\t{rolls[4][2]}\t{rolls[5][2]}\n" +
                       $"{rolls[0][3]}\t{rolls[1][3]}\t{rolls[2][3]}\t{rolls[3][3]}\t{rolls[4][3]}\t{rolls[5][3]}\n\n" +
                       $"{rolls[0][4]}\t{rolls[1][4]}\t{rolls[2][4]}\t{rolls[3][4]}\t{rolls[4][4]}\t{rolls[5][4]}\n\n" +
                       $"Total Roll: {rolls[0][4] + rolls[1][4] + rolls[2][4] + rolls[3][4] + rolls[4][4] + rolls[5][4]}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(details, "Details");
        }
    }
}
