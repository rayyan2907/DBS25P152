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
    public partial class show_allocations_grid : Form
    {
        string venue_id;

        public show_allocations_grid(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            venue_id = id;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void loadData()
        {
            DataTable dt = load_data_class.getVenuesAllocations(Convert.ToInt32( venue_id));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No venues allocations found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
           
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

        private void show_allocations_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            venueAllocate();

        }

        private void show_allocations_grid_Load(object sender, EventArgs e)
        {
        }

        public void venueAllocate()
        {
            assign_venue assign_ = new assign_venue(venue_id);
            assign_.Show();

        }
    }
}
