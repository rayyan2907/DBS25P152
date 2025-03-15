using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Itec_Mangement
{
    public partial class event_delete : Form
    {
        public event_delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                string name = comboBox4.Text;

                bool flag = events_class.event_del(name);

                if (flag)
                {
                    MessageBox.Show("Event deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox4.Refresh();
                }
                else
                {
                    MessageBox.Show("Deletion failed! Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




            //MessageBox.Show("Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void event_delete_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_data()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);
            DataTable dt = events_class.getEvents(id);

            if (dt != null || dt.Rows.Count > 0)
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "event_name";
                comboBox4.ValueMember = "event_id";


            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
