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
    public partial class duty_assignment : Form
    {
        public duty_assignment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void duty_assignment_Load(object sender, EventArgs e)
        {
            load_names();
            load_status();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string committee_id = comboBox1.SelectedValue.ToString();
            string assign_member = comboBox2.Text.ToString();
            string duty_id = textBox1.Text.Trim();
            string deadline = dateTimePicker1.Text.Trim();
            string description = textBox3.Text.Trim();
            string status_id = comboBox3.SelectedValue.ToString();

            bool flag = duty_class.assignDuty(duty_id, committee_id, assign_member,description, deadline, status_id);
            if (flag)
            {
                MessageBox.Show("Duty Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox1.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Error assinging duty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }






            //MessageBox.Show("Duty Assinged", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        public void load_names()
        {

            int id = Convert.ToInt32(GlobalData.ItecId);
            DataTable dt = duty_class.getCommittees(id);
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "committee_name";
                comboBox1.ValueMember = "committee_id";
            }
            else
            {
                MessageBox.Show("No committees found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public void load_members()
        {
            string name = comboBox1.SelectedValue.ToString();
            DataTable dt = duty_class.getMembers(Convert.ToInt32( name));

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
            }
            else
            {
                MessageBox.Show("No members found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void load_status()
        {
            DataTable dt = duty_class.getStatus();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "value";
                comboBox3.ValueMember = "lookup_id";
            }
            else
            {
                MessageBox.Show("Error loading status", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

      

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            load_members();
        }
    }
}
