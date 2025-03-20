using Google.Protobuf.Reflection;
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
    public partial class edit_venue : Form
    {
        string venue_id;
        public edit_venue(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            venue_id = id;

            textBox1.Text = venue_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();

            string venue_id = textBox1.Text.Trim();
            string venue_name = textBox2.Text.Trim();
            string capacity = textBox4.Text.Trim();
            string location = textBox3.Text.Trim();

            bool flag = venue_class.VenueUpadte(venue_id, venue_name, capacity, location);

            if (flag)
            {
                MessageBox.Show("Venue upadated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();


            }
            else
            {
                MessageBox.Show("Error updating venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox4.Clear();
            textBox3.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void edit_venue_Load(object sender, EventArgs e)
        {
            venues_load(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void venues_load(object sender, EventArgs e)
        {

            DataTable dt = venue_class.loadData(venue_id);



            if (dt != null)
            {
                textBox2.Text = dt.Rows[0]["venue_name"].ToString();
                textBox3.Text = dt.Rows[0]["location"].ToString();
                textBox4.Text = dt.Rows[0]["capacity"].ToString();
            }
            else
            {
                MessageBox.Show("No venues found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
