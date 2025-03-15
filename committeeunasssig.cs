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
    public partial class committeeunasssig : Form
    {
        public committeeunasssig()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Unassign_Click(object sender, EventArgs e)
        {
            string name = comboBox2.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to unassign?", "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                bool flag = commitees_class.del_commitee_member(name);

                if (flag)
                {
                    MessageBox.Show("Member unassigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBox1.Refresh();
                }
                else
                {
                    MessageBox.Show("Member unassugnment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Unassignment Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



          //  MessageBox.Show("Committee Unassigned", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void committeeunasssig_Load(object sender, EventArgs e)
        {
            load_names();
        }
        public void load_names()
        {

            int id = Convert.ToInt32(GlobalData.ItecId);
            DataTable dt = commitees_class.getCommittees(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "committee_name";
            }
            else
            {              
                MessageBox.Show("No commitees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            load_members();
        }
        public void load_members()
        {
            string name = comboBox1.Text;
            DataTable dt = commitees_class.getMemberNames(name);

            if (dt != null && dt.Rows.Count>0)
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show("No members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
    }
}
