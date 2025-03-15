using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class roles_class
    {
        public static bool add_role(string role_id , string role_name)
        {
            if (string.IsNullOrEmpty(role_id) || string.IsNullOrEmpty(role_name))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
                    
            };

            int role_id_int;
            bool is_role = int.TryParse(role_id, out role_id_int);

            if (!is_role)
            {
                MessageBox.Show("Roll ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }


            string query = $"Insert into roles values ('{role_id_int}','{role_name}')";

            int rows = DatabaseHelper.Instance.Update(query);
            return rows> 0;


           // return true;
        }
    }
}
