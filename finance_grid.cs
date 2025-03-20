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
    public partial class finance_grid : Form
    {
        public finance_grid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            sponsors_grid sponsors_Grid = new sponsors_grid();
            sponsors_Grid.TopLevel = false;
            panel1.Controls.Add(sponsors_Grid);
            sponsors_Grid.Show();


        }

        private void finance_grid_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();
        }

        private void button12_Click(object sender, EventArgs e)
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
            vendors_grid vendors_Grid = new vendors_grid();
            vendors_Grid.TopLevel = false;
            panel1.Controls.Add(vendors_Grid);
            vendors_Grid.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
           transactions_grid transactions_Grid = new transactions_grid();
            transactions_Grid.TopLevel = false;
            panel1.Controls.Add(transactions_Grid);
            transactions_Grid.Show();

        }
    }
}
