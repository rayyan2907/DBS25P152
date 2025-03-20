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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text.Trim();
            string password = textBox8.Text.Trim();
            string email = textBox1.Text.Trim();
            string role_id =comboBox3.SelectedValue.ToString();

            bool flag = user_class.register(username,password,email,role_id);
            if (flag) 
            {
                MessageBox.Show("You have registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                login_page login_Page = new login_page();
                login_Page.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error in Registration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
            loadRoles();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            login_page login_Page = new login_page();
            login_Page.Show();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox8.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void loadRoles()
        {
            DataTable dt = user_class.getRoles();
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "value";
                comboBox3.ValueMember = "lookup_id";
            }
        }
    }
}
