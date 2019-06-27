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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            XElement appSettings = XElement.Load(@"Data\Settings.xml");
            var settingDetails = from settings in appSettings.Elements("Settings")
                                 select settings;
            MessageBox.Show(settingDetails.First().Element("FontSize").Value);
            //settingDetails.First().Element("FontSize").Value = numFontSize.Text;
            //appSettings.Save(@"Data\Settings.xml");
            this.Close();
        }
    }
}
