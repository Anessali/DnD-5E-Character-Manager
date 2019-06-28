using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CharacterSheet.Edit
{
    public partial class EditRaces : Form
    {
        public int fontSize;
        DnDataSetDataContext conn = new DnDataSetDataContext();

        public EditRaces(int fontSize)
        {
            this.fontSize = fontSize;
            InitializeComponent();
            LoadData(fontSize);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dGridRaces.SelectedRows[0].Cells[0].Value.ToString());
            if (dGridRaces.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you wish to delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        EditRaces newWindow = new EditRaces(fontSize);
                        int raceId = Convert.ToInt32(dGridRaces.SelectedRows[0].Cells[0].Value);
                        Race obj = conn.Races.SingleOrDefault(E => E.Id == raceId);
                        conn.Races.DeleteOnSubmit(obj);
                        conn.SubmitChanges();
                        this.Close();
                        newWindow.Show();
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show("Cannot delete. Subraces exist using this race.");
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRace window = new AddRace(fontSize);
            if (window.ShowDialog() == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Used to load data on DataGrid
        /// </summary>
        private void LoadData(int fontSize)
        {
            dGridRaces.RowTemplate.Height = fontSize * 2 + 8;
            dGridRaces.DefaultCellStyle.Font = new Font("Arial", fontSize);
            dGridRaces.DataSource = conn.Races;
            dGridRaces.Sort(dGridNameColumn, ListSortDirection.Ascending);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditRaces newWindow = new EditRaces(fontSize);
            //MessageBox.Show(dGridRaces.SelectedRows[0].Cells[1].Value.ToString());
            AddRace f = new AddRace(true, Convert.ToInt32(dGridRaces.SelectedRows[0].Cells[0].Value));
            f.ButtonText = "Update";
            f.RaceName = dGridRaces.SelectedRows[0].Cells[1].Value.ToString();
            f.Str = dGridRaces.SelectedRows[0].Cells[3].Value.ToString();
            f.Dex = dGridRaces.SelectedRows[0].Cells[4].Value.ToString();
            f.Con = dGridRaces.SelectedRows[0].Cells[5].Value.ToString();
            f.Int = dGridRaces.SelectedRows[0].Cells[6].Value.ToString();
            f.Wis = dGridRaces.SelectedRows[0].Cells[7].Value.ToString();
            f.Cha = dGridRaces.SelectedRows[0].Cells[8].Value.ToString();
            f.ShowDialog();
            this.Close();
            newWindow.Show();
        }

        
    }
}
