﻿using System;
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
        DnDataSetDataContext db = new DnDataSetDataContext();
        public AddSubrace()
        {
            InitializeComponent();
        }

        private void AddSubrace_Load(object sender, EventArgs e)
        {
            var query =
                from race in db.Races
                select race.Name
                ;
            foreach (string race in query)
            {
                cbBoxRace.Items.Add(race);
            }
            cbBoxRace.Sorted = true;

            //XElement racesFile = XElement.Load("Data/Races/Races.xml");
            //IEnumerable<XElement> races =
            //    from race in racesFile.Descendants("Race")
            //    select race.Element("Name")
            //    ;
            //foreach (string race in races)
            //{
            //    cbBoxRace.Items.Add(race);
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}