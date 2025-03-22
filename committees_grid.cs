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
    public partial class committees_grid : Form
    {
        public committees_grid()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                delCommittee(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Assign Members")
            {
                assignMembers(sender, e);

            }
           

        }


        public void loadData()
        {
            DataTable dt = load_data_class.getCommittees(Convert.ToInt32(GlobalData.ItecId));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
           
        }

        private void committees_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            commitee_add commitee_Add   = new commitee_add();
            commitee_Add.Show();
        }

        private void committees_grid_Load(object sender, EventArgs e)
        {
            loadData();
        }


        public void delCommittee(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            commitee_del commitee_Del = new commitee_del(id); 
            commitee_Del.Show();
        }
        public void assignMembers(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            assignMembers_grid assignMembers_grid = new assignMembers_grid(id);
            assignMembers_grid.Show();

        }
    }
}
