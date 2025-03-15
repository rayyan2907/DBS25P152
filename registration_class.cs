using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class registration_class
    {

        public static DataTable getRolesName()
        {  //gets role name
            try
            {
                string query = "select * from roles";
                return DatabaseHelper.Instance.GetData(query);
            }
            catch
            {
                MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static bool DeleteName(string name)
        {  // deletes data
            
            
                string query = $"delete from participants where name = '{name}'";
                int rows= DatabaseHelper.Instance.Update(query);
                return rows > 0;
            
            
        }

        public static DataTable getParticipants(int year)
        {  //gets participants
            try
            {
                string query = $"select * from participants where itec_id = {year} ";
                return DatabaseHelper.Instance.GetData(query);
            }
            catch
            {
                MessageBox.Show("Unexpected Error. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
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
    }
}
