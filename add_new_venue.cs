using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
    public partial class add_new_venue : Form
    {
        public add_new_venue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string venue_id = textBox1.Text.Trim();
            string venue_name = textBox2.Text.Trim();
            string capacity = textBox4.Text.Trim();
            string location = textBox3.Text.Trim();

            bool flag = venue_class.VenueAdd(venue_id, venue_name, capacity, location);

            if (flag)
            {
                MessageBox.Show("Venue Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();


            }
            else
            {
                MessageBox.Show("Error saving venue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void add_new_venue_Load(object sender, EventArgs e)
        {
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
