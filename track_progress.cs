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
    public partial class track_progress : Form
    {
        public track_progress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel2.Hide();
            panel2.Visible = false;

            panel3.Visible = false;
            label7.Visible = false;
            panel4.Visible = false;

            label8.Visible = false;

            panel5.Visible = false;
            label9.Visible = false;

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async  void button2_Click(object sender, EventArgs e)
        {
            loading loading= new loading();
            loading.TopLevel = false;
            panel1.Controls.Add(loading);
            

            loading.Show();
            await Task.Delay(1500);
            loading.Close();
            panel2.Visible = true;

            await Task.Delay(500);
            panel3.Visible = true;
            await Task.Delay(250);
            label7.Visible = true;
            await Task.Delay(500);
            panel4.Visible = true;
           
            await Task.Delay(250);
            label8.Visible = true;

            await Task.Delay(500);
            panel5.Visible = true;
            await Task.Delay(250);
            label9.Visible = true;



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

        private  void panel5_Paint(object sender, PaintEventArgs e)
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
    }
}
