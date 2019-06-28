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
    public partial class EditSubraces : Form
    {
        int fontSize;
        DnDataSetDataContext conn = new DnDataSetDataContext();
        public EditSubraces(int fontSize)
        {
            this.fontSize = fontSize;
            InitializeComponent();
            LoadData(fontSize);
        }
        
        private void Races_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dGrid.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you wish to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int raceId = Convert.ToInt32(dGrid.SelectedRows[0].Cells[0].Value);
                    Subrace obj = conn.Subraces.SingleOrDefault(E => E.Id == raceId);
                    conn.Subraces.DeleteOnSubmit(obj);
                    conn.SubmitChanges();
                }
            }
            LoadData(fontSize);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSubrace window = new AddSubrace();
            EditSubraces newWindow = new EditSubraces(fontSize);
            this.Close();
            if (window.ShowDialog() == DialogResult.OK) {
                
                newWindow.Show();
            }
            //LoadData();
        }

        /// <summary>
        /// Used to load data on DataGrid
        /// </summary>
        private void LoadData(int fontSize)
        {
            dGrid.RowTemplate.Height = fontSize * 2 + 8;
            dGrid.DefaultCellStyle.Font = new Font("Arial", fontSize);
            dGrid.DataSource = conn.Subraces;
            dGrid.Sort(dGridNameColumn, ListSortDirection.Ascending);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = (int)dGrid.SelectedRows[0].Cells[0].Value,
                raceId = (int)dGrid.SelectedRows[0].Cells[1].Value;
            string name = "";
            LoadData load = new LoadData();

            var query = from race in conn.Races
                        where race.Id == raceId
                        select race.Name;

            foreach (string raceName in query)
            {
                name = raceName;
            }

            Edit.AddSubrace f = new Edit.AddSubrace(name, ID, true);
            f.txtName.Text = dGrid.SelectedRows[0].Cells[2].Value.ToString();
            f.btnAccept.Text = "Update";
            f.txtSpeed.Text = dGrid.SelectedRows[0].Cells[3].Value.ToString();
            f.txtStr.Text = dGrid.SelectedRows[0].Cells[4].Value.ToString();
            f.txtDex.Text = dGrid.SelectedRows[0].Cells[5].Value.ToString();
            f.txtCon.Text = dGrid.SelectedRows[0].Cells[6].Value.ToString();
            f.txtInt.Text = dGrid.SelectedRows[0].Cells[7].Value.ToString();
            f.txtWis.Text = dGrid.SelectedRows[0].Cells[8].Value.ToString();
            f.txtCha.Text = dGrid.SelectedRows[0].Cells[9].Value.ToString();

            f.Show();
        }
    }
}
