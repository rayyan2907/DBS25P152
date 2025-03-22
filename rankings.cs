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
    public partial class rankings : Form
    {
        public rankings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string event_id = comboBox3.SelectedValue.ToString();
            string participant_id = comboBox2.SelectedValue.ToString();
            string team_id = comboBox1.SelectedValue.ToString();
            string position = textBox6.Text.Trim();
            string score = textBox7.Text.Trim();
            string remarks = textBox3.Text.Trim();

            bool flag = results_class.addResult(event_id, participant_id, team_id, position, score, remarks);  
            if (flag)
            {
                MessageBox.Show("Resukt added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Error adding result.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox7.Clear();
            textBox6.Clear();

            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rankings_Load(object sender, EventArgs e)
        {
            loadEvents();
            loadTeams();
            loadParticipants();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadTeams()
        {
            DataTable team = results_class.getTeams(Convert.ToInt32(GlobalData.ItecId));

            if (team != null)
            {
                comboBox1.DataSource = team;
                comboBox1.DisplayMember = "team_name";
                comboBox1.ValueMember = "team_id";
                //this.Close();

            }

        }

        public void loadEvents()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = results_class.getEvents(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "event_name";
                comboBox3.ValueMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }

        }

        public void loadParticipants()
        {
            int id = Convert.ToInt32(GlobalData.ItecId);

            DataTable dt = results_class.getParticipants(id);

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "participant_id";
            }
            else
            {
                MessageBox.Show("No Participants found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

        }


    }
}
