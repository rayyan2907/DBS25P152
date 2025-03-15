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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Itec_Mangement
{
    public partial class commitee_add : Form
    {
        public commitee_add()
        {
            InitializeComponent();
            text4_name();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string id = textBox1.Text.Trim();
            string itec_id = GlobalData.ItecId;

            bool flag = commitees_class.commitee_add(name,itec_id,id);
            if (flag)
            {
                MessageBox.Show("Committee added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                textBox1.Clear();


            }
            else
            {
                MessageBox.Show("Error adding committee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //MessageBox.Show("Committee Added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1 .Clear();
            textBox2.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public void text4_name()
        {
            string year = GlobalData.ItecYear;
            textBox4.Text = year;
        }
    }
}
