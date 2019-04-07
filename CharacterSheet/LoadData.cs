using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CharacterSheet
{
    /// <summary>
    /// Class used to load in data, such as races.
    /// </summary>
    class LoadData
    {
        DnDataSetDataContext db = new DnDataSetDataContext();

        public LoadData()
        {

        }

        /// <summary>
        /// Loads races into combobox.
        /// </summary>
        /// <param name="races"></param>
        /// <returns></returns>
        public ComboBox Races(ComboBox races)
        {
            //ComboBox races = new ComboBox();
            var query = from race in db.Races
                        select race.Name;

            foreach (string race in query)
            {
                races.Items.Add(race);
            }
            races.Sorted = true;
            return races;
        }
    }
}
