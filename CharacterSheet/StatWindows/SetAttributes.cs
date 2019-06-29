using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet.StatWindows
{
    public partial class SetAttributes : Form
    {
        int str,
            dex,
            con,
            intel,
            wis,
            cha;

        private void btnSetAttributes_Click(object sender, EventArgs e)
        {
            Main window = new Main();
            //window.Str = Int32.Parse(txtStr.Text);
            //window.Dex = Int32.Parse(txtDex.Text);
            //window.Con = Int32.Parse(txtCon.Text);
            //window.Intel = Int32.Parse(txtInt.Text);
            //window.Wis = Int32.Parse(txtWis.Text);
            //window.Cha = Int32.Parse(txtCha.Text);
            window.LoadData();
            this.Close();
        }

        private void SetAttributes_Load(object sender, EventArgs e)
        {
            txtStr.Text = str.ToString();
            txtDex.Text = dex.ToString();
            txtCon.Text = con.ToString();
            txtInt.Text = intel.ToString();
            txtWis.Text = wis.ToString();
            txtCha.Text = cha.ToString();
        }

        /// <summary>
        /// Constructor for the SetAttributes class
        /// </summary>
        /// <param name="str"></param>
        /// <param name="dex"></param>
        /// <param name="con"></param>
        /// <param name="intel"></param>
        /// <param name="wis"></param>
        /// <param name="cha"></param>
        public SetAttributes(int str, int dex, int con, int intel, int wis, int cha)
        {
            this.str = str;
            this.dex = dex;
            this.con = con;
            this.intel = intel;
            this.wis = wis;
            this.cha = cha;
            InitializeComponent();
        }

        private void chkBxPointBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxPointBuy.Checked == true)
            {
                lblPoints.Show();
            }
            else
            {
                lblPoints.Hide();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtStr.Text = "8";
            txtDex.Text = "8";
            txtCon.Text = "8";
            txtInt.Text = "8";
            txtWis.Text = "8";
            txtCha.Text = "8";
        }
    }
}
