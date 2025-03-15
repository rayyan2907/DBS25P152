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
    public partial class commitee_del : Form
    {
        public commitee_del()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Unassign_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                string name = comboBox1.Text;

                bool flag = commitees_class.del_commitee(name);

                if (flag)
                {
                    MessageBox.Show("Committee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Deletion failed! Committee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            //MessageBox.Show("Committee Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commitee_del_Load(object sender, EventArgs e)
        {
            load_commitees();
        }

        private void load_commitees()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);
            DataTable dt = commitees_class.getCommittees(id);

            if (dt != null || dt.Rows.Count>0)
            {
                comboBox1.DataSource= dt;
                comboBox1.DisplayMember = "committee_name";
            }
            else
            {
                MessageBox.Show("No committes found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
