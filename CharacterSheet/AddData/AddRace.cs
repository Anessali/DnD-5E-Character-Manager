using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.AddData
{
    public partial class AddRace : Form
    {
        

        public AddRace()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a valid name");
            }
            else
            {
                //For more information: https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql/linq/how-to-connect-to-a-database
                DnDataSetDataContext db = new DnDataSetDataContext();
                Table<Race> Races = db.GetTable<Race>();

                

                Race race = new Race
                {
                    Name = txtName.Text,
                    Strength = Convert.ToInt32(txtStr.Text),
                    Dexterity = Convert.ToInt32(txtDex.Text),
                    Constitution = Convert.ToInt32(txtCon.Text),
                    Intelligence = Convert.ToInt32(txtInt.Text),
                    Wisdom = Convert.ToInt32(txtWis.Text),
                    Charisma = Convert.ToInt32(txtCha.Text)
                };

                db.Races.InsertOnSubmit(race);

                try
                {
                    db.SubmitChanges();
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    //db.SubmitChanges();
                }

                this.Close();
            }
        }
    }
}
