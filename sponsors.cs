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
    public partial class sponsors : Form
    {
        public sponsors()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void sponsors_Load(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.Trim();
            string contact = textBox4.Text.Trim(); 

            bool flag = finance_class.addSponsor(name, contact);
            if (flag)
            {
                MessageBox.Show("Event Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
