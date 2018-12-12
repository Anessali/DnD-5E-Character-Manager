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
        int roll;
        int maxRoll;

        /// <summary>
        /// roll refers to the dice roll. maxRoll is the maximum possible;
        /// for example, a D20 has a maxRoll of 20.
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="maxRoll"></param>
        public DiceMessageBox(int roll, int maxRoll)
        {
            this.Icon = CharacterSheet.Properties.Resources.d20_icon_34412_Windows;
            InitializeComponent();
            this.roll = roll;
            this.maxRoll = maxRoll + 1;
            lblRoll.Text = roll.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReroll_Click(object sender, EventArgs e)
        {
            Random roll = new Random();
            lblRoll.Text = roll.Next(1, maxRoll).ToString();
        }
    }
}
