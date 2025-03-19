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
    public partial class events_datagrid : Form
    {
        public events_datagrid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void events_datagrid_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            DataTable dt = load_data_class.getDataEvents(GlobalData.ItecId);
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                mainpage mainpage = new mainpage();
                mainpage.Show();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            eventadd eventadd = new eventadd();
            eventadd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                delEvent(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                updateEvent(sender, e);

            }


        }
        public void updateEvent(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["eventid"].Value.ToString();
            event_update event_update = new event_update(id);
            event_update.Show();
        }
        public void delEvent(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["eventid"].Value.ToString();

            event_delete event_delete = new event_delete(id);

            event_delete.Show();
        }

        private void events_datagrid_Activated(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
