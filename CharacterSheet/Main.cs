using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace CharacterSheet
{
    public partial class Main : Form
    {
        private int str,
            dex,
            con,
            intel,
            wis,
            cha;
        XElement settings = XElement.Load("Data/Settings.xml");
        readonly DnDataSetDataContext dataConn = new DnDataSetDataContext();
        Dice dice;

        #region Constructors
        public Main()
        {
            this.Icon = CharacterSheet.Properties.Resources.Iconcubic_Dnd_Dice_D12
               ;
            InitializeComponent();
        }
        public Main(int str)
        {
            this.str = str;
        }
        #endregion
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnDataDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dnDataDataSet.Inventory);
            dGridTypeColumn.Sorted = true;


            LoadRaces();
        }

        /// <summary>
        /// Sets values on page set on another form
        /// </summary>
        public void ReloadData()
        {
            //lblStr.Text = 20.ToString();
            MessageBox.Show(str.ToString());
            lblStr.Text = str.ToString();
        }

        #region Getters/setters for attributes
        public int Str {
            get { return str; }
            set { str = value; }
        }

        
        public int Dex { get => dex; set => dex = value; }
        public int Con { get => con; set => con = value; }
        public int Intel { get => intel; set => intel = value; }
        public int Wis { get => wis; set => wis = value; }
        public int Cha { get => cha; set => cha = value; }
        #endregion

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

        private void attributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dice = new Dice(6, 6, 6, 6);
            dice.Roll();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addSubraceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData.AddSubrace newSubrace = new AddData.AddSubrace();
            newSubrace.Show();
        }

        private void editRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.Races races = new Edit.Races();
            races.Show();
        }


        #region Inventory DataGrid
        private void btnUpdateTest_Click(object sender, EventArgs e)
        {
            //DataContext dc = new DataContext();
            //Table<Inventory> inventory = dc.GetTable<Inventory>();
            //var query = from inv in Inventory
            //            where inv.Id == 13
            //            select inv;

            //foreach (var inv in query)
            //{
            //    MessageBox.Show($"id = {inv.Item}");
            //}


            //MessageBox.Show(dnDataDataSet.Inventory.DataSet.ToString());

            
        }

        private void dGridInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.inventoryTableAdapter.Update(this.dnDataDataSet.Inventory);
        }

        private void dGridInventory_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.inventoryTableAdapter.Update(this.dnDataDataSet.Inventory);
        }

        #endregion

        /// <summary>
        /// Loads data in Races.xml
        /// </summary>
        public void LoadRaces()
        {
            XElement racesFile = XElement.Load("Data/Races/Races.xml");
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

            XElement racesFile = XElement.Load("Data/Races/Subraces.xml");

            IEnumerable<XElement> subraces = 
                from subrace in racesFile.Descendants("Subrace")
                where (string)subrace.Attribute("Type") == cbBoxRace.Text
                select subrace;

            foreach (var subrace in subraces)
            {
                cbBoxSubrace.Items.Add(subrace.Element("Name").Value);
            }

        }

        private void addRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData.AddRace newRace = new AddData.AddRace();
            newRace.Show();
        }

        private void btnSetAttributes_Click(object sender, EventArgs e)
        {
            int str = Int32.Parse(lblStr.Text),
                dex = Int32.Parse(lblDex.Text),
                con = Int32.Parse(lblCon.Text),
                intel = Int32.Parse(lblInt.Text),
                wis = Int32.Parse(lblWis.Text),
                cha = Int32.Parse(lblCha.Text);
            StatWindows.SetAttributes newWindow = new StatWindows.SetAttributes(str, dex, con, intel, wis, cha);
            newWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}