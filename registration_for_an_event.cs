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
    public partial class registration_for_an_event : Form
    {
        public registration_for_an_event()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear ();
           
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
