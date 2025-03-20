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
            
        }

        private void venues_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add_new_venue add_New_Venue = new add_new_venue();
            add_New_Venue.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                delVenue(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                updateVenue(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Check Allocations")
            {
                showAllocations(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Allocate")
            {
                venueAllocate(sender, e);

            }
        }

        public void updateVenue(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            edit_venue edit_Venue = new edit_venue(id);
            edit_Venue.Show();
        }
        public void delVenue(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            delete_venue delete_Venue = new delete_venue(id);
            delete_Venue.Show();
           
        }
        public void venueAllocate(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            assign_venue assign_ = new assign_venue(id);
            assign_.Show();

        }
        public void showAllocations(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            show_allocations_grid show_Allocations_Grid = new show_allocations_grid(id);
            show_Allocations_Grid.Show();

        }
    }
}
