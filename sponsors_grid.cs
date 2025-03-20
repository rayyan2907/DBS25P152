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
    public partial class sponsors_grid : Form
    {
        public sponsors_grid()
        {
            InitializeComponent();
        }

        private void sponsors_grid_Load(object sender, EventArgs e)
        {
                
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sponsors sponsors = new sponsors();
            sponsors.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        public void loadData()
        {
            DataTable dt = load_data_class.getSponsors();
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No sponsors found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        private void sponsors_grid_Activated(object sender, EventArgs e)
        {
            loadData();
            loadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
