using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class venue_class
    {
        public static bool VenueAdd(string venue_id, string venue_name,string capacity, string location)
        {
            if (string.IsNullOrEmpty(venue_id) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(venue_name) || string.IsNullOrEmpty(capacity)  ) 
            {
				MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return false;
			}

            int venue_id_int, capacity_int;

            bool is_venue= int.TryParse(venue_id, out venue_id_int);
            bool is_capacity = int.TryParse(capacity, out capacity_int);
            
            if (!is_capacity || ! is_venue)
            {
				MessageBox.Show("Venue ID and Capacity must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

            string query = $"insert into venues values ('{venue_id_int}','{venue_name}','{capacity_int}','{location}')";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

            
        }
        public static DataTable load_venues()
        { //for loading data and adding in combo box
            try
            {
                string query = "select venue_id from venues";
                return DatabaseHelper.Instance.GetData(query);
            }
            catch
            {
				MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
        }
		public static DataTable load_venues_name()
		{ //for loading name and adding in combo box
			try
			{
				string query = "select venue_name from venues";
				return DatabaseHelper.Instance.GetData(query);
			}
			catch
			{
				MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		public static DataTable loadData(string venue_id)
        {
            try
            {
                string query = $"select * from venues where venue_id = '{venue_id}'";
                return DatabaseHelper.Instance.GetData(query);
            }
            catch
            {
				MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
        }

		public static bool VenueUpadte(string venue_id, string venue_name, string capacity, string location)
		{
			if (string.IsNullOrEmpty(venue_id) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(venue_name) || string.IsNullOrEmpty(capacity))
			{
				MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

				return false;
			}

			int venue_id_int, capacity_int;

			bool is_venue = int.TryParse(venue_id, out venue_id_int);
			bool is_capacity = int.TryParse(capacity, out capacity_int);

			if (!is_capacity || !is_venue)
			{
				MessageBox.Show("Venue ID and Capacity must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			string query = $"update venues set venue_name = '{venue_name}', capacity= '{capacity_int}', location = '{location}' where venue_id = '{venue_id}'";

			int rows = DatabaseHelper.Instance.Update(query);
			return rows > 0;


		}

		public static bool venue_del(string name)
		{
			string query =  $"delete from venues where venue_name = '{name}'";
			int rows = DatabaseHelper.Instance.Update(query);
			return rows > 0;
		}

	}
}
