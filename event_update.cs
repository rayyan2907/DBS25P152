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
    public partial class event_update : Form
    {
        public event_update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string committee_id = null;
            string event_name = textBox2.Text.Trim();
            string event_id = comboBox4.Text;
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


            bool flag = events_class.update_event(event_name, event_id, itec_id, committee_id, description, date, venue_id, event_categorty_id);
            if (flag)
            {
                MessageBox.Show("Event Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox6.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox7.Clear();
                textBox2.Clear();

            }
            else
            {
                MessageBox.Show("Error updating event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //MessageBox.Show("Upadted!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox7.Clear();
            textBox2.Clear();

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void event_update_Load(object sender, EventArgs e)
        {
            load_events();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void load_events()
        {
            textBox4.Text= GlobalData.ItecYear;
            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = events_class.getEvents(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_data();
          
        }
        public void load_data()
        {
            string id = comboBox4.Text;
            DataTable dt = events_class.getData(id);

            if (dt != null  && dt.Rows.Count>0)
            {
                categories();
                load_venues();
                load_commitee();

                textBox2.Text = dt.Rows[0]["event_name"].ToString();
                textBox7.Text = dt.Rows[0]["committee_name"].ToString();
                textBox3.Text = dt.Rows[0]["description"].ToString();
                textBox5.Text = dt.Rows[0]["venue_name"].ToString();
                textBox6.Text = dt.Rows[0]["category_name"].ToString();
                textBox1.Text = dt.Rows[0]["event_date"].ToString();


            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
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

            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
