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
    public partial class assign_venue : Form
    {
        string venue;
        public assign_venue(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            venue= id;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string venue_all_id = textBox1.Text.Trim();
            string venue_id = venue;
            string events_id = comboBox1.SelectedValue.ToString();

            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd"); 
            string time = dateTimePicker2.Value.ToString("HH:mm:ss"); 

                    bool flag = venue_allocation_class.allocate_venue(venue_all_id,venue_id,events_id,date,time);
            if (flag)
            {
                MessageBox.Show("Venue assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox1.Clear();
                
                
            }
            else
            {
                MessageBox.Show("Error assigning venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }








            //MessageBox.Show("Assign", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void assign_venue_Load(object sender, EventArgs e)
        {
            load_venues();
            load_events();
        }

        public void load_venues()
        {
            DataTable dt = venue_class.loadData(venue);

            textBox2.Text = dt.Rows[0]["venue_name"].ToString();

        }

        public void load_events()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = venue_class.getEvents(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "event_name";
                comboBox1.ValueMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "No Events Found.";

            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
