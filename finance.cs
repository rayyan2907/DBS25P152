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
    public partial class finance : Form
    {
        public finance()
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

        private void finance_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vendors vendors = new vendors();
            vendors.TopLevel = false;
            panel3.Controls.Add(vendors);
            vendors.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sponsors sponsors = new sponsors();
            sponsors.TopLevel = false;
            panel3.Controls.Add(sponsors);
            sponsors.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transaction transaction = new transaction();
            transaction.TopLevel = false;
            panel3.Controls.Add(transaction);
            transaction.Show();
        }
    }

}
