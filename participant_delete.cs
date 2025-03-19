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
    public partial class participant_delete : Form
    {
        public participant_delete(string id)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            int par_id= Convert.ToInt32(id);
            load_names(par_id);

        }

        private void participant_delete_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Confirmation",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {


                string name = textBox4.Text;

            bool flag = registration_class.DeleteName(name);

            if (flag)
            {
                MessageBox.Show("Participant deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
            else
            {
                MessageBox.Show("Deletion failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Deletion Cancelled!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }

    //MessageBox.Show("Participant Deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

}

private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void load_names(int year)
        {

            DataTable dt = registration_class.getParticipants(year);
            textBox4.Text = dt.Rows[0]["name"].ToString();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
