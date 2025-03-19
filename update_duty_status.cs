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
    public partial class update_duty_status : Form
    {
        string duty_id;
        public update_duty_status(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            duty_id= id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string duty_id = textBox6.Text;
            string status_id = comboBox3.SelectedValue.ToString();

            bool flag = duty_class.updateDuty(duty_id, status_id);
            if (flag)
            {
                MessageBox.Show("Duty status updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox1.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Error updating duty status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();


            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_duty_status_Load(object sender, EventArgs e)
        {

            loadDuty();

            loadData();


        }
        public void load_status()
        {
            string name = comboBox3.Text;
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

        public void loadDuty()
        {
            int id = Convert.ToInt32(duty_id);

            DataTable dt = duty_class.getDuty(id);
            textBox6.Text = dt.Rows[0]["duty_id"].ToString();


        }

        public void loadData()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);
            int duty = Convert.ToInt32(textBox6.Text);


            DataTable dt = duty_class.getData(id,duty);

            if (dt != null && dt.Rows.Count > 0)
            {
                load_status();

                textBox2.Text = dt.Rows[0]["deadline"].ToString();
                textBox3.Text = dt.Rows[0]["task_description"].ToString();
                textBox5.Text = dt.Rows[0]["assigned_to"].ToString();
                textBox1.Text = dt.Rows[0]["committee_name"].ToString();
                textBox4.Text = dt.Rows[0]["value"].ToString();


            }
            else
            {
                MessageBox.Show("No duties found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
