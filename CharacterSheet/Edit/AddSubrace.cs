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

namespace CharacterSheet.Edit
{
    public partial class AddSubrace : Form
    {
        bool beingEdited = false;
        int id; //primary key for Subrace
        int raceID; //foreign key for Race
        DnDataSetDataContext db = new DnDataSetDataContext();
        public AddSubrace()
        {
            InitializeComponent();
            LoadRaces();
        }

        public AddSubrace(string name, int id, bool edited)
        {
            InitializeComponent();
            LoadRaces();
            cbBoxRace.Text = name;
            this.id = id;
            this.beingEdited = edited;
        }

        private void AddSubrace_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Loads races on this form
        /// </summary>
        public void LoadRaces()
        {
            var query = from race in db.Races
                        select race.Name;

            foreach (string race in query)
            {
                cbBoxRace.Items.Add(race);
            }
            cbBoxRace.Sorted = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || cbBoxRace.Text == "")
            {
                MessageBox.Show("Missing required information");
            }
            else
            {
                if (beingEdited == false)
                {

                    var query = from race in db.Races
                                where race.Name == cbBoxRace.Text
                                select race.Id;
                    
                    //Sets the race foreign key
                    foreach (int ID in query)
                    {
                        raceID = ID;
                    }

                    Subrace sub = new Subrace
                    {
                        Name = txtName.Text,
                        RaceId = raceID,
                        Speed = Convert.ToInt32(txtSpeed.Text),
                        Strength = Convert.ToInt32(txtStr.Text),
                        Dexterity = Convert.ToInt32(txtDex.Text),
                        Constitution = Convert.ToInt32(txtCon.Text),
                        Intelligence = Convert.ToInt32(txtInt.Text),
                        Wisdom = Convert.ToInt32(txtWis.Text),
                        Charisma = Convert.ToInt32(txtCha.Text)
                    };

                    db.Subraces.InsertOnSubmit(sub);
                    db.SubmitChanges();
                    this.Close();
                }
                else
                {
                    //updates race ID if necessary
                    var raceQuery = from race in db.Races
                                    where race.Name == cbBoxRace.Text
                                    select race.Id;

                    foreach (int id in raceQuery)
                    {
                        raceID = id;
                    }

                    var query = from subrace in db.Subraces
                                where subrace.Id == id
                                select subrace;
                    
                    foreach (Subrace sub in query)
                    {
                        sub.RaceId = raceID;
                        sub.Name = txtName.Text;
                        sub.Speed = (int)txtSpeed.Value;
                        sub.Strength = (int)txtStr.Value;
                        sub.Dexterity = (int)txtDex.Value;
                        sub.Constitution = (int)txtCon.Value;
                        sub.Intelligence = (int)txtInt.Value;
                        sub.Wisdom = (int)txtWis.Value;
                        sub.Charisma = (int)txtCha.Value;
                    }
                    try
                    {
                        db.SubmitChanges();
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show($"Error: {exc}");
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
