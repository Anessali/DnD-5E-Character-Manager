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
        int fontSize;
        //string characterSheet;
        
        DnDataSetDataContext db = new DnDataSetDataContext();
        LoadData load = new LoadData();
        Dice dice;

        #region Constructors

        /// <summary>
        /// Main constructor where everything is loaded.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Iconcubic_Dnd_Dice_D12;

            try
            {
                var settings = XElement.Load("Data/Settings.xml");
                this.fontSize = Convert.ToInt32(settings.Element("FontSize").Value);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Settings file not found. Generating new one...");
                XDocument newDoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Settings",
                        new XElement("FontSize", "14")
                    )
                );

                newDoc.Save(@"Data\Settings.xml");
            }

            LoadData();

            //loads in data from LoadRaces class - pulls from LoadData.cs
            //cbBoxRace = load.Races(cbBoxRace);
        }

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

        #region toolstrip

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.Settings newWindow = new Edit.Settings();
            newWindow.ShowDialog();

            //XElement settings = XElement.Load("Data/Settings.xml");
                                 
            /* Some example code for personal use. Generates an XML document using Linq to XML
            XDocument newDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating example XML doc"),
                new XElement("Animals",
                    new XElement("Animal", new XAttribute("Id", 101),
                        new XElement("Name", "Cat"),
                        new XElement("Species", "Cat")
                        )
                    )
                );
             
            newDoc.Save(@"Data\Example.xml");   
             */
            /* Updating an xml element
                xmlDoc.Element("Students")
                      .Elements("Student")
                      .Where(x => x.Attribute("Id").Value == "106")
                      .Select(x => x.Element("TotalMarks")).FirstOrDefault().SetValue(999);
                
            */

            //MessageBox.Show(fontSize.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subracesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edit.EditSubraces window = new Edit.EditSubraces(fontSize);
            window.Show();
        }

        private void addSubraceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit.AddSubrace newSubrace = new Edit.AddSubrace();
            newSubrace.Show();
        }

        private void editRacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditRaces races = new Edit.EditRaces(fontSize);
            races.Show();
        }
        #endregion

        #region Inventory DataGrid

        private void dGridInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Table<Inventory> inventory = conn.GetTable<Inventory>();
            UpdateInventory();

        }

        private void EditCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.Character newWindow = new Edit.Character();
            newWindow.ShowDialog();
        }

        /// <summary>
        /// Runs constantly. Possibly slowing application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dGridInventory_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateInventory();
        }
        #endregion

        #region void methods that run repetitive code
        
        public void UpdateInventory()
        {
            try
            {
                this.Validate();
                this.inventoryBindingSource.EndEdit();
                this.inventoryTableAdapter.Update(this.dnDataDataSet.Inventory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex}");
            }
        }

        public void LoadData()
        {
            // TODO: This line of code loads data into the 'dnDataDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dnDataDataSet.Inventory);
            dGridTypeColumn.Sorted = true;
        }
        #endregion

        private void cbBoxRace_TextChanged(object sender, EventArgs e)
        {
            //First clears the combo box
            //cbBoxSubrace.Items.Clear();

            //var raceQuery = from race in db.Races
            //                join subrace in db.Subraces on race.Id equals subrace.RaceId
            //                where race.Name == cbBoxRace.Text
            //                select subrace.Name
            //                ;
            //foreach (string subrace in raceQuery )
            //{
            //    cbBoxSubrace.Items.Add(subrace);
            //}
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
    }
}