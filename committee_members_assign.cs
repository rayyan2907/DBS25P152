using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Itec_Mangement
{
    public partial class committee_members_assign : Form
    {
        public committee_members_assign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox6.Clear();
            //textBox1.Clear();
            textBox2.Clear();
            //textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string member_id = textBox2.Text.Trim();
            string member_name = textBox1.Text.Trim();
            string role_id = comboBox1.SelectedValue.ToString();
            string committee_id = comboBox2.SelectedValue.ToString();

            bool flag = commitees_class.assign_members(member_id, member_name,committee_id,role_id);
            if (flag)
            {
                MessageBox.Show("Member Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear() ;

            }
            else
            {
                MessageBox.Show("Error assigning member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void committee_members_assign_Load(object sender, EventArgs e)
        {
            loadRole_ids();
            loadCommittees();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadRole_ids()
        {
            DataTable dt = commitees_class.getRoleNames();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "role_name";
                comboBox1.ValueMember = "role_id";
            }
            else
            {
                MessageBox.Show("No roles found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void loadCommittees()
        {

            int id = Convert.ToInt32( GlobalData.ItecId);
            DataTable dt = commitees_class.getCommittees(id);

            if (dt != null  && dt.Rows.Count > 0) 
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "committee_name";
                comboBox2.ValueMember = "committee_id";
            }
            else
            {
                MessageBox.Show("No committees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
