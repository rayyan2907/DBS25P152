using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Itec_Mangement
{
    public class user_class
    {

        public static DataTable checkLogin (string username, string password)
        {
            if (string.IsNullOrEmpty (username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            string query = $"select * from users u join lookup l on l.lookup_id=u.role_id where username = '{username}' and password_hash = '{password}'";
            return DatabaseHelper.Instance.GetData(query) ;
        }


        public static DataTable getRoles()
        {
            string query = $"select * from lookup where category = 'UserRoles'";
            return DatabaseHelper.Instance.GetData(query);
        }


        
        public static bool register(string username, string password,string email,string role)
        {
            if (string.IsNullOrEmpty (username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty (email) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            int id_int;
            bool is_event = int.TryParse(role, out id_int);
            if (!is_event)
            {
                MessageBox.Show("Unknown error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into users (username,email,password_hash,role_id) values ('{username}','{email}','{password}',{role})";

            int rows = DatabaseHelper.Instance.Update(query) ;
            return rows>0 ;
        }

    }
}
