using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class finance_class
    {
        public static bool addVendor(string id , string name , string contact , string service)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(service))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            int id_int;
            bool is_id = int.TryParse(id, out id_int);
            if (!is_id)
            {
                MessageBox.Show("Vendor ID must be in numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string query = $"insert into vendors values ({id_int},'{name}','{contact}','{service}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }
    }
}
