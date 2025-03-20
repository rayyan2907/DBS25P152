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
    public partial class duty_grid : Form
    {
        public duty_grid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Track Progress")
            {
                trackProgress(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update Progress")
            {
                updateProgress(sender, e);

            }
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
        public void loadData()
        {
            DataTable dt = load_data_class.getDuties(Convert.ToInt32( GlobalData.ItecId));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
           
        }

        private void duty_grid_Load(object sender, EventArgs e)
        {

        }

        private void duty_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }
        public void trackProgress(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            track_progress track_Progress = new track_progress(id);
            track_Progress.Show();
        }
        public void updateProgress(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

            update_duty_status update_Duty_Status = new update_duty_status(id);
            update_Duty_Status.Show();
        }

        
        public void addDuty(object sender, EventArgs e)
        {


            duty_assignment duty_Assignment = new duty_assignment();
            duty_Assignment.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            addDuty(sender, e);

        }
    }
}
