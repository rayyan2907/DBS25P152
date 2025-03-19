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
    public partial class registration_for_an_event : Form
    {
        string globalid;
        public registration_for_an_event(string id  )
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            globalid = id;
            int part_id = Convert.ToInt32( id );
            loadParticipants(part_id);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox6.Clear ();
           
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reg_id = textBox1.Text.Trim();
           // MessageBox.Show(globalid);
            string participant_id  = globalid;
            string event_id = comboBox3.SelectedValue.ToString();
            string fees = textBox6.Text.Trim();
            string status_id = comboBox1.SelectedValue.ToString();



            bool flag = registration_class.register_student(reg_id, participant_id,event_id,fees,status_id);
            if (flag)
            {
                MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox1.Clear();
                textBox6.Clear();

            }
            else
            {
                MessageBox.Show("Error in registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            //  MessageBox.Show("Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registration_for_an_event_Load(object sender, EventArgs e)
        {
            loadEvents();
            loadStatus();
        }

        public void loadEvents()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = registration_class.getEvents(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "event_name";
                comboBox3.ValueMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        public void loadParticipants(int id)
        {

            DataTable dt = registration_class.getParticipants(id);
            textBox2.Text = dt.Rows[0]["name"].ToString();

        }

        public void loadStatus()
        {

            DataTable dt = registration_class.getStatus();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "value";
                comboBox1.ValueMember = "lookup_id";
            }
            else
            {
                MessageBox.Show("Error getting payment info.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
