using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Itec_Mangement
{
    public partial class committeeunasssig : Form
    {
        string member_id;
        string committee_id;
        public committeeunasssig(string id,string com_id)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            member_id = id;
            committee_id = com_id;
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
            string id = member_id;

            DialogResult result = MessageBox.Show("Are you sure you want to unassign?", "Confirmation",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                bool flag = commitees_class.del_commitee_member(id);

                if (flag)
                {
                    MessageBox.Show("Member unassigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Member unassugnment failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Unassignment Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

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
            load_members();

        }
        public void load_names()
        {

            int id = Convert.ToInt32(committee_id);
            DataTable dt = commitees_class.getCommittees(id);
            textBox2.Text = dt.Rows[0]["committee_name"].ToString();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
        public void load_members()
        {
            
            DataTable dt = commitees_class.getMemberNames(member_id);
            textBox1.Text = dt.Rows[0]["name"].ToString();




        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


///unassign form 