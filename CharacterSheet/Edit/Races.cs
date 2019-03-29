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
    public partial class Races : Form
    {
        DnDataSetDataContext conn = new DnDataSetDataContext();
        public Races()
        {
            InitializeComponent();
        }

        private void Races_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dnDataDataSet.Races' table. You can move, or remove it, as needed.
            this.racesTableAdapter.Fill(this.dnDataDataSet.Races);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
