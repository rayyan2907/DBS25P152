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
    public partial class registration_new : Form
    {
        public registration_new()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }

        private void registration_new_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            DataTable dt = load_data_class.getParticipants(Convert.ToInt32(GlobalData.ItecId));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

            registration_student registration_Student = new registration_student();
            registration_Student.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                delParticipant(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                updateParticipant(sender, e);

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Register")
            {
                registerParticipant(sender, e);

            }

        }

        public void updateParticipant(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            participant_update abv = new participant_update(id);
            abv.Show();
        }
        public void delParticipant(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            participant_delete participant_Delete = new participant_delete(id);
            participant_Delete.Show();
            
        }
        public void registerParticipant(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            registration_for_an_event registration_For_An_Event = new registration_for_an_event(id);
            registration_For_An_Event.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            team_add team_Add = new team_add();
            team_Add.Show();
        }

        private void registration_new_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
