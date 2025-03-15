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
    public partial class event_categories : Form
    {
        public event_categories()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text.Trim();
            string name = textBox3.Text.Trim();
            bool flag = events_class.add_category(id, name);

            if (flag)
            {
                MessageBox.Show("Events upadated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                textBox3.Clear();
                
            }
            else
            {
                MessageBox.Show("Error updating event.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear ();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
