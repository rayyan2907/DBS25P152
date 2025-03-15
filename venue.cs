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
    public partial class venue : Form
    {
        public venue()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_new_venue new_Venue = new add_new_venue();
            new_Venue.TopLevel = false;
            panel3.Controls.Add(new_Venue);
            new_Venue.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            assign_venue assign_Venue= new assign_venue();
            assign_Venue.TopLevel = false;
            panel3.Controls.Add(assign_Venue);
            assign_Venue.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit_venue edit_Venue=new edit_venue();
            edit_Venue.TopLevel = false;
     
            panel3.Controls.Add(edit_Venue);
            edit_Venue.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_venue delete_Venue =new delete_venue();
            delete_Venue.TopLevel = false;
            panel3.Controls.Add(delete_Venue);
            delete_Venue.Show();
        }

        private void venue_Load(object sender, EventArgs e)
        {

        }
    }
}
