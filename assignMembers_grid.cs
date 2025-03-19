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
    public partial class assignMembers_grid : Form
    {
        string temp;
        public assignMembers_grid(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            temp = id;
        }

        private void assignMembers_grid_Load(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

            committeeunasssig committeeunasssig = new committeeunasssig(id,temp);
            committeeunasssig.Show();
        }


        public void loadData()
        {
            DataTable dt = load_data_class.getCommitteeData(Convert.ToInt32(temp));
            
                dataGridView1.DataSource = dt;

           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            committee_members_assign committee_Members_Assign = new committee_members_assign(temp);
            committee_Members_Assign.Show();
        }

        private void assignMembers_grid_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
