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
        string temp;
        public event_delete(string event_id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            int id = Convert.ToInt32(event_id);
            temp = event_id;
            load_data(id);

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

                bool flag = events_class.event_del(temp);

                if (flag)
                {
                    MessageBox.Show("Event deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deletion failed! Event not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }




            //MessageBox.Show("Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void event_delete_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_data(int id)
        {
            DataTable dt = events_class.getEvents(id);
            textBox4.Text = dt.Rows[0]["event_name"].ToString();
            


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
