using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class team_class
    {

        public static DataTable load_event(int id)
        {
            string query = $"select * from itec_events where itec_id = {id}";
            return DatabaseHelper.Instance.GetData(query) ;
        }

        public static bool addteam(string name,string event_id)
        {
            if (string.IsNullOrEmpty(name) ||  string.IsNullOrEmpty(event_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int event_id_int;

            bool is_event = int.TryParse(event_id, out event_id_int);

            if (!is_event)
            {
                MessageBox.Show("Team ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into teams (event_id , team_name ) values ({event_id_int},'{name}')";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }
    }
}
