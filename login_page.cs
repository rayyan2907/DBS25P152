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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void login_page_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string user_name = textBox2.Text.Trim();
            string password = textBox8.Text.Trim();
            string role;


            DataTable dt = user_class.checkLogin(user_name, password);
            if (dt != null && dt.Rows.Count > 0)
            {
                role= dt.Rows[0]["value"].ToString();
                userLogin(role);
            }
            else
            {
                MessageBox.Show("Incorrect Username and password.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                textBox8.Clear();
               // role = "";
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox8.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            signup signup = new signup();
            signup.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void userLogin(string role)
        {
            if (role == "Admin")
            {
                MessageBox.Show("You have logged in as admin", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                itec_edition itec_Edition = new itec_edition();
                itec_Edition.Show();
                this.Hide();

            }
            else if (role == "Faculty")
            {
                MessageBox.Show("You have logged in as faculty member", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (role == "Student")
            {
                MessageBox.Show("You have logged in as student", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (role == "Sponsor")
            {
                MessageBox.Show("You have logged in as sponsor", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

