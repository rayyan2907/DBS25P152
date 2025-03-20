using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public class finance_class
    {
        public static bool addVendor(string name , string contact , string service)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(service))
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            string query = $"insert into vendors (vendor_name,contact,service_type) values ('{name}','{contact}','{service}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }



        public static bool addSponsor(string name , string contact)
        {

            if( string.IsNullOrEmpty(name) || string.IsNullOrEmpty(contact) )
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            

            string query = $"insert into sponsors (sponsor_name,contact) values ('{name}','{contact}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;
        }

        public static DataTable getEvents(int id)
        {
            string query = $"select * from itec_events where itec_id={id}";
            return DatabaseHelper.Instance.GetData(query);
        }
        public static DataTable getFinanceTypes()
        {
            string query = $"select * from lookup where category = 'FinanceTypes'";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static DataTable getEntityTypes()
        {
            string query = $"select * from lookup where category = 'EntityTypes'";
            return DatabaseHelper.Instance.GetData(query);
        }

        public static bool addTransaction(string itec_id, string event_id, string trasaction_type,string amount, string description, string date,string f_e_type,string f_e_id, string t_e_id, string t_e_type)
        {
            if (string.IsNullOrEmpty(itec_id) || string.IsNullOrEmpty(event_id) || string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(trasaction_type) || string.IsNullOrEmpty (description))   
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }


            

            string query = $"insert into finances (itec_id,event_id,type_id,amount,from_entity_type,from_entity_id,to_entity_type,to_entity_id,description,date_recorded) values ({Convert.ToInt32(itec_id)},{Convert.ToInt32(event_id)},{Convert.ToInt32(trasaction_type)},{Convert.ToDecimal(amount)},'{f_e_type}' ,{Convert.ToInt32(f_e_id)}, '{t_e_type}' ,{Convert.ToInt32(t_e_id)}, '{description}','{date}')";

            int rows = DatabaseHelper.Instance.Update(query);


            return rows > 0;

        }

    }
}
