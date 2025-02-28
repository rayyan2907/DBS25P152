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
    public partial class committee_members_assign : Form
    {
        public committee_members_assign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
