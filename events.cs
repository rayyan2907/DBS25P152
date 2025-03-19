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
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void events_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        { 

            string a = "";
            event_update event_update = new event_update(a);
            event_update.TopLevel = false;
            panel3.Controls.Add(event_update);
            event_update.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            eventadd eventadd = new eventadd();
            eventadd.TopLevel = false;
            panel3.Controls.Add(eventadd);
            eventadd.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "";
            event_delete event_delete = new event_delete(a);
            event_delete.TopLevel = false;
            panel3.Controls.Add(event_delete);
            event_delete.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            event_categories event_Categories = new event_categories(); 
            event_Categories.TopLevel = false;
            panel3.Controls.Add(event_Categories);
            event_Categories.Show();
        }
    }
}
