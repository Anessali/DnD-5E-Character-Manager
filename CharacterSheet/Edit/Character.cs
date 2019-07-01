using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.Edit
{
    public partial class Character : Form
    {
        DnDataSetDataContext db = new DnDataSetDataContext();
        LoadData load = new LoadData();
        public Character()
        {
            InitializeComponent();
            cbRace = load.Races(cbRace);
        }

        private void CbRace_TextChanged(object sender, EventArgs e)
        {
            //First clears the combo box
            //cbSubrace.Items.Clear();

            var raceQuery = from race in db.Races
                            join subrace in db.Subraces on race.Id equals subrace.RaceId
                            where race.Name == cbSubrace.Text
                            select subrace.Name
                            ;
            foreach (string subrace in raceQuery)
            {
                cbSubrace.Items.Add(subrace);
            }
        }
    }
}
