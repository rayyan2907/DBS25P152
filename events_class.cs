using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class events_class 
    {
        public static bool add_category(string id, string name)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) )
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false; 
            }


            int event_id;
            bool is_event = int.TryParse(id, out event_id);
            if (!is_event)
            {
                MessageBox.Show("Event ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }

            string query = $"insert into event_categories values ('{event_id}','{name}')";

            int rows = DatabaseHelper.Instance.Update(query);

            
            return rows > 0;

        }


        public static DataTable getEventCategory()
        {
            string query = "select * from event_categories";
            return DatabaseHelper.Instance.GetData(query);
        }


        public static DataTable getVenues()
        {
            string query = "select * from venues";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getCommittee(int id)
        {
            string query = $"select * from committees where itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getEvents(int id)
        {
            string query = $"select * from itec_events where itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getData(string id)
        {
            string query = $"select * from itec_events i join committees c on c.committee_id = i.committee_id join venues v on v.venue_id = i.venue_id join event_categories ec on ec.event_category_id= i.event_category_id join committees cm on cm.committee_id=i.committee_id where event_id='{id}'";
            return DatabaseHelper.Instance.GetData(query);
        }


        public static bool add_event(string event_name,string event_id,string itec_id,string committee_id,string description,string date,string venue,string event_category_id)
        {
            if (string.IsNullOrEmpty(event_name) || string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty(itec_id) || string.IsNullOrEmpty(committee_id) || string.IsNullOrEmpty (description) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(venue) || string.IsNullOrEmpty(event_category_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            int event_id_int;
            bool is_event = int.TryParse(event_id , out event_id_int);
            if (!is_event)
            {
                MessageBox.Show("Event ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int itec_id_int = Convert.ToInt32(itec_id);
            int committee_id_int = Convert.ToInt32(committee_id);
            int event_category_id_int = Convert.ToInt32(event_category_id);
            int venue_id_int= Convert.ToInt32(venue);
            string formattedDate = DateTime.Parse(date).ToString("yyyy-MM-dd");


            string query = $"insert into itec_events values ({event_id},{itec_id_int},'{event_name}',{event_category_id_int},'{description}','{formattedDate}',{venue_id_int},{committee_id_int})";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }

        public static bool update_event(string event_name, string event_id, string itec_id, string committee_id, string description, string date, string venue, string event_category_id)
        {
            if (string.IsNullOrEmpty(event_name) || string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty(itec_id) || string.IsNullOrEmpty(committee_id) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(venue) || string.IsNullOrEmpty(event_category_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            int event_id_int;
            bool is_event = int.TryParse(event_id, out event_id_int);
            if (!is_event)
            {
                MessageBox.Show("Event ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int itec_id_int = Convert.ToInt32(itec_id);
            int committee_id_int = Convert.ToInt32(committee_id);
            int event_category_id_int = Convert.ToInt32(event_category_id);
            int venue_id_int = Convert.ToInt32(venue);
            string formattedDate = DateTime.Parse(date).ToString("yyyy-MM-dd");


            string query = $"update itec_events set itec_id = {itec_id_int}, event_name ='{event_name}', event_category_id={event_category_id_int},description='{description}',event_date='{formattedDate}',venue_id={venue_id_int},committee_id={committee_id_int} where event_id = {event_id_int}";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }

        public static bool event_del(string name)
        {
            string query = $"delete from itec_events where event_name = '{name}'";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }

    }
}
