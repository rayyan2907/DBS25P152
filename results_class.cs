using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class results_class
    {
        public static DataTable getEvents(int id)
        {
            string query = $"select * from itec_events where itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);
        }
        public static DataTable getParticipants(int year)
        {  


            string query = $"select * from participants where itec_id = {year} ";
            return DatabaseHelper.Instance.GetData(query);

        }
        public static DataTable getTeams(int id)
        {  //gets role name

            string query = $"select * from teams t join itec_events e on e.event_id=t.event_id where itec_id = {id}";
            return DatabaseHelper.Instance.GetData(query);


        }
        public static bool addResult(string event_id ,string participant_id , string team_id ,string position, string score ,string remarks)
        {
            if (string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty(participant_id) || string.IsNullOrEmpty(team_id) || string.IsNullOrEmpty(position) || string.IsNullOrEmpty(score) || string.IsNullOrEmpty(remarks))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int participant_int, position_int, team_int;
            decimal score_decimal;
            bool is_par=int.TryParse(participant_id, out participant_int);
            bool is_event = int.TryParse(event_id, out int event_int);
            bool is_pos= int.TryParse(position, out position_int);
            bool is_score = decimal.TryParse(score, out score_decimal);
            bool is_team = int.TryParse(team_id, out team_int);

            if (!is_par || !is_event || !is_pos || !is_score)
            {
                MessageBox.Show("Position and Score must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



            string query = $"insert into event_results (event_id,participant_id,team_id,position,score,remarks) values ({event_int},{participant_int},{team_int},{position_int},{score_decimal},'{remarks}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }
    }
}
