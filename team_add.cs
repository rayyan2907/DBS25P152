using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Itec_Mangement
{
    public partial class team_add : Form
    {
        public team_add()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string team_name = textBox2.Text.Trim();
            string team_id = textBox3.Text.Trim();
            string event_id = comboBox1.SelectedValue.ToString();

            bool flag = team_class.addteam(team_name,team_id , event_id);
            if (flag)
            {
                MessageBox.Show("Team added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                textBox2.Clear();
                textBox3.Clear();


            }
            else
            {
                MessageBox.Show("Error adding team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            //textBox4.Clear();  
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void get_data()
        {
            int year = Convert.ToInt32(GlobalData.ItecId);
            DataTable dt = team_class.load_event(year);
            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "event_name";
                comboBox1.ValueMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Text = "No Events Found.";
            }
        }

        private void team_add_Load(object sender, EventArgs e)
        {
            get_data();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
