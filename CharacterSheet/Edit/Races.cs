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
            //dGridRaces.DataSource = conn.Races;
            //dGridRaces.Columns["Id"].Visible = false;

            lstBxRaces.
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
