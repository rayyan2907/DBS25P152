 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class duty_class
    {
        public static DataTable getCommittees(int itec_id)
        {
            string query = $"select * from committees where itec_id = {itec_id} order by committee_id asc";

            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getData(int itec_id,int duty_id)
        {
            string query = $"select * from duties d join committees c on c.committee_id = d.committee_id join lookup l on l.lookup_id = d.status_id where itec_id= {itec_id} and duty_id = {duty_id}";

            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getDuty(int id)
        {
            string query = $"select * from duties d join committees c on c.committee_id = d.committee_id join lookup l on l.lookup_id = d.status_id where duty_id= {id}";

            return DatabaseHelper.Instance.GetData(query);
        }



        public static DataTable getMembers(string names)
        {
            string query = $"select * from committee_members cm join committees c on cm.committee_id = c.committee_id where cm.committee_id = '{names}'";

            return DatabaseHelper.Instance.GetData(query);
        }
        public static DataTable getStatus()
        {
            string query = $"select * from lookup where category = 'DutyStatus' ";

            return DatabaseHelper.Instance.GetData(query);
        }

        public static bool assignDuty(string duty_id,string committee_id ,string assign_to , string description , string deadline , string status_id)
        {

            if (string.IsNullOrEmpty(duty_id) || string.IsNullOrEmpty(committee_id) || string.IsNullOrEmpty(assign_to) || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(deadline) || string.IsNullOrEmpty(status_id))   
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int duty_id_int , status_id_int , committee_id_int;

            bool is_duty = int.TryParse(duty_id,out duty_id_int);
            status_id_int = Convert.ToInt32(status_id);
            committee_id_int = Convert.ToInt32(committee_id);
            string formattedDate = DateTime.Parse(deadline).ToString("yyyy-MM-dd");


            if (!is_duty)
            {
                MessageBox.Show("Duty ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into duties values ({duty_id_int},{committee_id_int},'{assign_to}','{description}','{formattedDate}',{status_id_int})";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;


        }

        public static bool updateDuty(string duty_id,string status_id)
        {

            if (string.IsNullOrEmpty(duty_id) ||  string.IsNullOrEmpty(status_id))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int duty_id_int, status_id_int;

            bool is_duty = int.TryParse(duty_id, out duty_id_int);
            status_id_int = Convert.ToInt32(status_id);
          


            if (!is_duty)
            {
                MessageBox.Show("Duty ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"update duties set  status_id = {status_id_int} where duty_id = {duty_id_int}";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;


        }














    }


   



}
