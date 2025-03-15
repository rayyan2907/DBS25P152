using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class venue_allocation_class
    {
        public static DataTable getVenues()
        {
            string query = "select * from venues";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getEvents(int id)
        {
            string query = $"select * from itec_events where itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);
        }


        public static bool allocate_venue(string all_id, string venue_id , string event_id,string date,string time)
        {
            if (string.IsNullOrEmpty(all_id) || string.IsNullOrEmpty(venue_id) || string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty (date) || string.IsNullOrEmpty(time))  
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            int all_id_int,venue_id_int,event_id_int;
            bool is_all_int = int.TryParse(all_id, out all_id_int);
            bool is_venue = int.TryParse(venue_id,out venue_id_int) ;
            bool is_event = int.TryParse(event_id, out event_id_int);


            if (!is_all_int)
            {
                MessageBox.Show("Allocation ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            

            string query = $"insert into venue_allocations values ({all_id_int},{event_id_int},{venue_id_int},'{date}','{time}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;
        }

    }
}
