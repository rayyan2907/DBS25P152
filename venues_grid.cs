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
    public partial class venues_grid : Form
    {
        public venues_grid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void venues_grid_Load(object sender, EventArgs e)
        {

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

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();
        }


        public void loadData()
        {
            DataTable dt = load_data_class.getVenues();
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No venues found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                mainpage mainpage = new mainpage();
                mainpage.Show();

            }
        }

        private void venues_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
