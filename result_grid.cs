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
    public partial class result_grid : Form
    {
        public result_grid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void result_grid_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void loadData()
        {
            DataTable dt = load_data_class.getEventResults(Convert.ToInt32( GlobalData.ItecId));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No event results found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                mainpage mainpage = new mainpage();
                mainpage.Show();

            }
        }

        private void result_grid_Activated(object sender, EventArgs e)
        {
            loadData();
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

        private void button11_Click(object sender, EventArgs e)
        {
            rankings rankings = new rankings();
            rankings.Show();
        }
    }
}
