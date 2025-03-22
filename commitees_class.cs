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
        public static bool commitee_add(string name,string itec_id)
        {

            Convert.ToInt32(itec_id);
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(itec_id) )
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }



            string query = $"insert into committees (itec_id,committee_name) values ({itec_id},'{name}')";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

            //return true;
        }

        public static DataTable getCommittees(int id)
        {
            string query = $"select * from committees where committee_id = {id}";

            return DatabaseHelper.Instance.GetData(query);
        }

        
        public static DataTable getMemberNames(string names)
        {
            string query = $"select name from committee_members where member_id = '{names}'";

            return DatabaseHelper.Instance.GetData(query);
        }


        public static bool del_commitee(string name)
        {
            string query = $"delete from committees where committee_id = '{name}'";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }


        public static bool del_commitee_member(string name)
        {
            string query = $"delete from committee_members where member_id = '{name}'";
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;
        }




        public static DataTable getRoleNames()
        {
            string query = "select * from roles where role_id >= 30";
            return DatabaseHelper.Instance.GetData(query);

            
        }


        public static bool assign_members(string member_name,string committee_id,string role_id)
        {
            if(string.IsNullOrEmpty(member_name) || string.IsNullOrEmpty(committee_id) || string.IsNullOrEmpty(role_id))
            {
				MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            int  role_id_int, commitee_id_int;

            role_id_int = Convert.ToInt32(role_id);
            commitee_id_int = Convert.ToInt32(committee_id);

            string query = $"insert into committee_members (committee_id , name,role_id) values ({commitee_id_int},'{member_name}',{role_id_int})";
           
            // MessageBox.Show(query);
            int rows = DatabaseHelper.Instance.Update(query);
            return rows > 0;

        }
    }
}



