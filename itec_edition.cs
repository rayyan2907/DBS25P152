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
    
    public partial class itec_edition : Form
    {
       
        public itec_edition()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void itec_edition_Load(object sender, EventArgs e)
        {
            itec_edition_load(sender, e);
            panel2.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            panel1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();

            panel2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string itec_id = textBox1.Text.Trim();
            string year = textBox2.Text.Trim();
            string theme = textBox3.Text.Trim();
            string description = textBox4.Text.Trim();
            bool flag = itec_edition_class.AddEdition(itec_id, year, theme,description);

            if (flag)
            {
                MessageBox.Show("Edition Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error saving edition.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            login_page login_page = new login_page();
            login_page.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
      

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void itec_edition_load(object sender, EventArgs e)
        {
            LoadEditions();
        }

        private void LoadEditions()
        {
            DataTable editions = itec_edition_class.load_editions();

            if (editions != null && editions.Rows.Count > 0)
            {

                comboBox1.DataSource = editions;  
                comboBox1.DisplayMember = "year";
                comboBox1.ValueMember = "itec_id";
            }
            else
            {
                MessageBox.Show("No editions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            string year = comboBox1.Text;
            string Itec_Id= comboBox1.SelectedValue.ToString();
            //MessageBox.Show(Itec_Id);
            //MessageBox.Show(year);
            this.Hide();

            loading load = new loading();
            load.Show();

            await Task.Delay(500);

            load.Hide();
            mainpage main =new mainpage();
            main.SetYear(year);
            main.SetItecId(Itec_Id);

            main.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            login_page login_page = new login_page();
            login_page.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }
    }

}

