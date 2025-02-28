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
            committee_update = new committee_update();
        }
    }
}
