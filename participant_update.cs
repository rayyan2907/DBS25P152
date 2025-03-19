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
        public partial class participant_update : Form
        {
            public participant_update(string id)
            {
                
                InitializeComponent();
                this.StartPosition = FormStartPosition.CenterScreen;
                textBox7.Text = id;



        }

        private void participant_update_Load(object sender, EventArgs e)
            {

                string year = GlobalData.ItecYear;
                textBox4.Text = year;
                name();
                loadData();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void button1_Click(object sender, EventArgs e)
            {

                textBox1.Clear();
                //textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
           
                textBox1.Focus ();

                MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            private void button2_Click(object sender, EventArgs e)
            {



                string participant_id = textBox7.Text;
                string name = textBox1.Text.Trim();
                string email = textBox6.Text.Trim();
                string contact_details = textBox5.Text.Trim();
                string institute = textBox3.Text.Trim();
                string itec_id = GlobalData.ItecId;
                string role_id = comboBox1.SelectedValue.ToString();


                bool flag = registration_class.participant_update(participant_id, name, itec_id, email, contact_details, institute, role_id);
                if (flag)
                {
                    MessageBox.Show("Participant updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                   // textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox1.Clear();



                }
                else
                {
                    MessageBox.Show("Error updating participant.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                //MessageBox.Show("Participant Updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            private void textBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void name()
            {
                DataTable role = registration_class.getRolesName();

                if (role != null && role.Rows.Count>0)
                {
                    comboBox1.DataSource = role;
                    comboBox1.DisplayMember = "role_name";
                    comboBox1.ValueMember = "role_id";
                }
            else
            {
                MessageBox.Show("No roles found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
            

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void loadData() 
            {
                string participant_id = textBox7.Text;
                DataTable dt = registration_class.getDetails(participant_id,GlobalData.ItecId);
            
                if (dt != null && dt.Rows.Count > 0 )
                {
                    textBox1.Text = dt.Rows[0]["name"].ToString();
                    textBox4.Text = dt.Rows[0]["year"].ToString();
                    textBox6.Text = dt.Rows[0]["email"].ToString();
                    textBox5.Text = dt.Rows[0]["contact"].ToString();
                    textBox3.Text = dt.Rows[0]["institute"].ToString();
                    textBox2.Text = dt.Rows[0]["role_name"].ToString();

                }
                else
                {
                    MessageBox.Show("No participants found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
