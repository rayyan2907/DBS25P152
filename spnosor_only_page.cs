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
    public partial class spnosor_only_page : Form
    {
        public spnosor_only_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            login_page login_page = new login_page();
            login_page.Show();
            this.Hide();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void spnosor_only_page_Load(object sender, EventArgs e)
        {



            sponsors_grid sponsors_Grid = new sponsors_grid();
            sponsors_Grid.TopLevel = false;
            panel1.Controls.Add(sponsors_Grid);
            sponsors_Grid.Show();

        }
    }
}
