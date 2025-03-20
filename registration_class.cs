using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Itec_Mangement
{
    public class registration_class
    {

        public static DataTable getRolesName()
        {  //gets role name
           
                string query = "select * from roles where role_id < 35";
                return DatabaseHelper.Instance.GetData(query);
            
          
        }
        public static DataTable getTeams(int id)
        {  //gets role name

            string query = $"select * from teams t join itec_events e on e.event_id=t.event_id where itec_id = {id}";
            return DatabaseHelper.Instance.GetData(query);


        }
        public static bool DeleteName(string name)
        {  // deletes data
            
            
                string query = $"delete from participants where name = '{name}'";
                int rows= DatabaseHelper.Instance.Update(query);
                return rows > 0;
            
            
        }

        public static DataTable getParticipants(int year)
        {  //gets participants
           
         
                string query = $"select name from participants where participant_id = {year} ";
                return DatabaseHelper.Instance.GetData(query);
            
        }

        public static DataTable getEvents(int id)
        {
            //get events
            string query = $"select * from itec_events where itec_id= {id}";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getStatus()
        {
            //get payment status id from lookup

            string query = "select * from lookup where category = 'PaymentStatus' ";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getDetails(string id,string year)
        {  //gets specific participants
            try
            {
                string query = $"select * from participants p join roles r on r.role_id = p.role_id join itec_editions i on i.itec_id=p.itec_id where participant_id = {id} ";
                return DatabaseHelper.Instance.GetData(query);
            }
            catch
            {
                MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public static bool participant_add(string participant_id ,string name,string itec_id,string email,string contact,string institute,string role_id)
        {
            if (string.IsNullOrEmpty(participant_id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(itec_id) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(institute) || string.IsNullOrEmpty(role_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            int participant_int, itec_id_int, role_id_name;

            bool is_participant = int.TryParse(participant_id, out participant_int);
            bool is_itec=int.TryParse(itec_id,  out itec_id_int);
            bool is_role=int.TryParse(role_id, out role_id_name);

            if (!is_participant || !is_itec ||!is_role)
            {
                MessageBox.Show("IDs must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into participants values ({participant_int},{itec_id_int},'{name}','{email}','{contact}','{institute}',{role_id_name})";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0; 


        }

        public static bool participant_update(string participant_id, string name, string itec_id, string email, string contact, string institute, string role_id)
        {
            if (string.IsNullOrEmpty(participant_id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(itec_id) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(institute) || string.IsNullOrEmpty(role_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            int participant_int, itec_id_int, role_id_name;

            bool is_participant = int.TryParse(participant_id, out participant_int);
            bool is_itec = int.TryParse(itec_id, out itec_id_int);
            bool is_role = int.TryParse(role_id, out role_id_name);

            if (!is_participant || !is_itec || !is_role)
            {
                MessageBox.Show("IDs must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"update participants set itec_id = {itec_id_int}, name ='{name}', email= '{email}', contact = '{contact}', institute = '{institute}', role_id={role_id_name} where participant_id = {participant_int}";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

            
        }


        public static bool register_student(string reg_id, string participant_id, string event_id, string fees, string status_id)
        {// registering student i an event

            if (string.IsNullOrEmpty(reg_id) || string.IsNullOrEmpty(participant_id) || string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty(fees) || string.IsNullOrEmpty(status_id))
            {

                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                return false;
            }
            //MessageBox.Show(reg_id + "  " + participant_id + "  " + event_id);

            int reg_id_int, participant_id_int, event_id_int, fees_int, status_int;

            bool is_id = int.TryParse(reg_id, out reg_id_int);
            bool is_fees = int.TryParse(fees, out fees_int);

            event_id_int = Convert.ToInt32(event_id);
            participant_id_int = Convert.ToInt32(participant_id);
            status_int = Convert.ToInt32(status_id);
             
            if (!is_id || !is_fees)
            {
                MessageBox.Show("Registration id and fees must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            string query = $"insert into event_participants values ({reg_id_int},{event_id_int},{participant_id_int},{status_int},{fees_int})";
//            MessageBox.Show(query);





            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }


        public static bool addToTeam(string participant_id , string team_id)
        {
            if (string.IsNullOrEmpty(participant_id) || string.IsNullOrEmpty(team_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            int participant_int, team_int;

            bool is_participant = int.TryParse(participant_id, out participant_int);
            team_int=Convert.ToInt32(team_id);

         
            string query = $"insert into team_participants values ({team_int},{participant_int})";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

        }
    }
}
