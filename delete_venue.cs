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
    public partial class delete_venue : Form
    {
        string venue_id;

        public delete_venue(string id)
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;

            venue_id = id;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                string venue_name = venue_id;

                bool flag = venue_class.venue_del(venue_name);

                if (flag)
                {
                    MessageBox.Show("Venue deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deletion failed! Venue not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void delete_venue_Load(object sender, EventArgs e)
        {
            del(sender, e);
        }
        private void del(object sender, EventArgs e) 
        
        {
            DataTable dt = venue_class.load_venues_name(venue_id);

            textBox1.Text = dt.Rows[0]["venue_name"].ToString();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
