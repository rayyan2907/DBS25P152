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
    public partial class vendors_grid : Form
    {
        public vendors_grid()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void loadData()
        {
            DataTable dt = load_data_class.getVendors();
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No vendors found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void vendors_grid_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vendors vendors = new vendors();
            vendors.Show();
        }
    }
}
