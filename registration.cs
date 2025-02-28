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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void registration_Load(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {
            itec_edition itec = new itec_edition();
            this.Hide();
            itec.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            registration_student registration = new registration_student();
            registration.TopLevel = false;
            panel3.Controls.Add(registration);
            registration.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            participant_update part_new = new participant_update();
            part_new.TopLevel = false;
            panel3.Controls.Add(part_new);
            part_new.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            registration_for_an_event reg = new registration_for_an_event();
            reg.TopLevel = false;
            panel3.Controls.Add(reg);
            reg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            participant_delete part_del = new participant_delete();
            part_del.TopLevel = false;
            panel3.Controls.Add(part_del);
            part_del.Show();
        }
    }
}
