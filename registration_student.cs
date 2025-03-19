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
    
    public partial class registration_student : Form
    {
        public registration_student()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string participant_id = textBox2.Text.Trim();
            string name = textBox1.Text.Trim();
            string email = textBox6.Text.Trim();
            string contact_details = textBox5.Text.Trim();
            string institute = textBox3.Text.Trim();
            string itec_id = GlobalData.ItecId;
            string role_id = comboBox1.SelectedValue.ToString();


            bool flag = registration_class.participant_add(participant_id,name,itec_id,email,contact_details,institute,role_id);
            if (flag)
            {
                MessageBox.Show("Participant added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox1.Clear();
                

            }
            else
            {
                MessageBox.Show("Error adding participant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            //MessageBox.Show("Participant Added", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           // textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
           

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void registration_student_Load(object sender, EventArgs e)
        {

            string year = GlobalData.ItecYear;
            textBox4.Text = year;
            name();
            


        }
        
        private void name()
        {
            DataTable role = registration_class.getRolesName();

            if (role != null)
            {
                comboBox1.DataSource = role;
                comboBox1.DisplayMember = "role_name";
                comboBox1.ValueMember = "role_id";
            }



        }

        private void textBox4_Text(object sender, EventArgs e)
        {
        }

        private void label10_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
