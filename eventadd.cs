using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Itec_Mangement
{
    public partial class eventadd : Form
    {
        public eventadd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void eventadd_Load(object sender, EventArgs e)
        {
            string year = GlobalData.ItecYear.ToString();
            textBox4.Text = year;


            categories();
            load_venues();
            load_commitee();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string committee_id = null;
            string event_name = textBox2.Text.Trim();
            string event_id = textBox1.Text.Trim();
            string itec_id = GlobalData.ItecId.ToString();
            if (comboBox3.DataSource != null && comboBox3.SelectedValue != null)
            {
                committee_id = comboBox3.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("No committees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //committee_id = null;
            }
            string description = textBox3.Text.Trim();
            string date = dateTimePicker1.Text;
            string venue_id = comboBox1.SelectedValue.ToString();
            string event_categorty_id = comboBox2.SelectedValue.ToString();


            bool flag = events_class.add_event(event_name,event_id,itec_id,committee_id,description,date,venue_id,event_categorty_id);
            if (flag)
            {
                MessageBox.Show("Event Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();


            }
            else
            {
                MessageBox.Show("Error adding event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void categories()
        {
            DataTable dt = events_class.getEventCategory();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "category_name";
                comboBox2.ValueMember = "event_category_id";
            }
            else
            {
                MessageBox.Show("No categories found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void load_venues()
        {
            DataTable dt = events_class.getVenues();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "venue_name";
                comboBox1.ValueMember = "venue_id";
            }
            else
            {
                MessageBox.Show("No venues found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }



        public void load_commitee()
        {

            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = events_class.getCommittee(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "committee_name";
                comboBox3.ValueMember = "committee_id";
            }
            else
            {
                MessageBox.Show("No committees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // comboBox3.ValueMember = null;

            }

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
