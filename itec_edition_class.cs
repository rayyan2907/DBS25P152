using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class itec_edition_class
    {
        public static bool AddEdition( string year, string theme, string description)
        { // to add new edition
            if (string.IsNullOrEmpty(year) || string.IsNullOrEmpty(theme) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            int itec_id_int, year_int;

            //bool is_itec = int.TryParse(itec_id, out itec_id_int);
            bool is_year = int.TryParse(year, out year_int);

            if ( !is_year)
            {
                MessageBox.Show("Year must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }




            string query = $"INSERT INTO itec_editions (year,theme,description) VALUES ('{year}', '{theme}', '{description}')";

            
            int rows = DatabaseHelper.Instance.Update(query);

            return rows > 0;
        
        }

        public static DataTable load_editions()
        {
            try
            {
                string query = "select  itec_id,year from itec_editions order by year desc";
                return DatabaseHelper.Instance.GetData(query);

            }
            catch 
            {
                MessageBox.Show("Unexpected Error. " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }





    


    }
}
