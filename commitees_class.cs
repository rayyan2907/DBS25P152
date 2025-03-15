using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Windows.Forms;
using System.Data;

namespace Itec_Mangement
{
    public class commitees_class
    {
        public static bool commitee_add(string name,string itec_id,string id)
        {

            Convert.ToInt32(itec_id);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) )
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int id_int;

            bool is_id = int.TryParse(id , out id_int);

            if (!is_id)
            {
                MessageBox.Show("Committee ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into committees values ({id},{itec_id},'{name}')";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

            //return true;
        }

        public static DataTable getCommittees(int itec_id)
        {
            string query = $"select * from committees where itec_id = {itec_id}";

            return DatabaseHelper.Instance.GetData(query);
        }

        
        public static DataTable getMemberNames(string names)
        {
            string query = $"select * from committee_members cm join committees c on cm.committee_id = c.committee_id where committee_name = '{names}'";

            return DatabaseHelper.Instance.GetData(query);
        }


        public static bool del_commitee(string name)
        {
            string query = $"delete from committees where committee_name = '{name}'";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }


        public static bool del_commitee_member(string name)
        {
            string query = $"delete from committee_members where name = '{name}'";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }




        public static DataTable getRoleNames()
        {
            string query = "select * from roles";
            return DatabaseHelper.Instance.GetData(query);

            
        }


        public static bool assign_members(string member_id,string member_name,string committee_id,string role_id)
        {
            if (string.IsNullOrEmpty(member_id) || string.IsNullOrEmpty(member_name) || string.IsNullOrEmpty(committee_id) || string.IsNullOrEmpty(role_id))
            {
				MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int member_id_int, role_id_int, commitee_id_int;

            bool is_member = int.TryParse(member_id, out member_id_int);
            role_id_int = Convert.ToInt32(role_id);
            commitee_id_int = Convert.ToInt32(committee_id);

            if (!is_member)
            {
                MessageBox.Show("Member ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false ;
            }

            string query = $"insert into committee_members values ({member_id_int},{commitee_id_int},'{member_name}',{role_id_int})";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

        }
    }
}



