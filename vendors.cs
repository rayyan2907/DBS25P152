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
    public partial class vendors : Form
    {
        public vendors()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vendor_id = textBox1.Text.Trim();
            string name = textBox2.Text.Trim();
            string contact = textBox4.Text.Trim();
            string service_type = textBox7.Text.Trim();


            bool flag = finance_class.addVendor(vendor_id , name,contact,service_type);
            if (flag)
            {
                MessageBox.Show("Vendor Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox7.Clear();
            }
            else
            {
                MessageBox.Show("Error adding vendor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox7.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void vendors_Load(object sender, EventArgs e)
        {

        }
    }
}
