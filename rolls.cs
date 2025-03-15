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
    public partial class rolls : Form
    {
        public rolls()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void button4_Click(object sender, EventArgs e)
        {
            commitee_add com_add = new commitee_add();
            com_add.TopLevel = false;
            panel3.Controls.Add(com_add);
            com_add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            committee_members_assign committee_Assign = new committee_members_assign();
            committee_Assign.TopLevel = false;
            panel3.Controls.Add(committee_Assign);
            committee_Assign.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            committeeunasssig committee_Update = new committeeunasssig();
            committee_Update.TopLevel = false;
            panel3.Controls.Add(committee_Update);
            committee_Update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            commitee_del commitee_Delete = new commitee_del();
            commitee_Delete.TopLevel = false;
            panel3.Controls.Add(commitee_Delete);
            commitee_Delete.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            committeeunasssig committee_Update = new committeeunasssig();
            committee_Update.TopLevel = false;
            panel3.Controls.Add(committee_Update);
            committee_Update.Show();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            roles_add roles_add = new roles_add();
            roles_add.TopLevel = false;
            panel3.Controls.Add(roles_add);
            roles_add.Show();
        }
    }
}
