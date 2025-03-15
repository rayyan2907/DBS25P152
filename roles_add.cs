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
    public partial class roles_add : Form
    {
        public roles_add()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role_id = textBox1.Text.Trim();
            string role_name = textBox2.Text.Trim();

            bool flag = roles_class.add_role(role_id, role_name);
            if (flag)
            {
                MessageBox.Show("Role Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();



            }
            else
            {
                MessageBox.Show("Error saving role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
