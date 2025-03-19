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
    public partial class track_progress : Form
    {
        string status;
        string duty_id;

        public track_progress(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            duty_id= id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loading loading = new loading();
            loading.TopLevel = false;
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadDuty()
        {
            int id = Convert.ToInt32(duty_id);

            DataTable dt = duty_class.getDuty(id);
            textBox4.Text = dt.Rows[0]["duty_id"].ToString();
            loadData();


        }

        private void track_progress_Load(object sender, EventArgs e)
        {
            loadDuty();
        }
        public void loadData()
        {
            panel6.Visible=true;
            int id = Convert.ToInt32(GlobalData.ItecId);
            int duty = Convert.ToInt32(textBox4.Text);

            DataTable dt = duty_class.getData(id, duty);

            if (dt != null && dt.Rows.Count > 0)
            {

                textBox3.Text = dt.Rows[0]["task_description"].ToString();

                status = dt.Rows[0]["value"].ToString();


            }
            else
            {
                MessageBox.Show("No duty found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private async void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();

            if (status == "Pending")
            {
                panel1.Show();
                await Task.Delay(250);
                label4.Show();
                
                await Task.Delay(100);

                panel3.Show();
            }
            if (status == "In Progress")
            {
                panel1.Show();
                await Task.Delay(250);
                label4.Show();

                await Task.Delay(100);

                panel3.Show();
                await Task.Delay(250);
                label7.Show();
                await Task.Delay(250);
                label5.Show();
                await Task.Delay(100);

                panel4.Show();
            }
            if (status == "Completed")
            {
                panel1.Show();
                await Task.Delay(250);
                label4.Show();

                await Task.Delay(100);

                panel3.Show();
                await Task.Delay(250);
                label7.Show();
                await Task.Delay(250);
                label5.Show();
                await Task.Delay(100);

                panel4.Show();
                await Task.Delay(250);
                label8.Show();

                await Task.Delay(250);
                label6.Show();
                await Task.Delay(100);

                panel5.Show();
                await Task.Delay(250);
                label9.Show();

            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel1.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            panel3.Hide();
            panel4.Hide();  
            panel5.Hide();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
