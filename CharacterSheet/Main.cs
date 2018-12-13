using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CharacterSheet
{
    public partial class Main : Form
    {
        Dice dice;
        public Main()
        {
            this.Icon = CharacterSheet.Properties.Resources.d20_icon_34412_Windows;
            InitializeComponent();
        }

        public void AddRaces()
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Dice Rolling
        private void d20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(20);
            dice.Roll();
        }

        private void d12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(12);
            dice.Roll();
        }

        private void d10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(10);
            dice.Roll();
        }

        private void d8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(8);
            dice.Roll();
        }

        private void d6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(6);
            dice.Roll();
        }

        private void d4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(4);
            dice.Roll();
        }
        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            XElement racesFile = XElement.Load("Data/Races.xml");
            IEnumerable<XElement> races =
                from race in racesFile.Descendants("Race")
                select race.Element("Name")
                ;
            foreach (string race in races)
            {
                cbBoxRace.Items.Add(race);
            }
        }

        private void cbBoxRace_TextChanged(object sender, EventArgs e)
        {
            //First clears the combo box
            cbBoxSubrace.Items.Clear();

            //MessageBox.Show("Test");
            XElement racesFile = XElement.Load("Data/Races.xml");
            //Incomplete
            IEnumerable<XElement> races =
                from race in racesFile.Elements("Race")
                where (string)race.Attribute("Name") == cbBoxRace.Text
                select race
                ;

            foreach (string race in races)
            {
                //cbBoxSubrace.Items.Add(race);
                MessageBox.Show(race);
            }
        }
    }
}