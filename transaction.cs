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
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            loadEvents();
            loadFinaneTypes();
            loadEntityTypes1();
            loadEntityTypes();

            textBox2.Text=GlobalData.ItecYear.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadEvents()
        {
            DataTable dt = finance_class.getEvents(Convert.ToInt32(GlobalData.ItecId));

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox4.DataSource = dt;
                comboBox4.DisplayMember = "event_name";
                comboBox4.ValueMember = "event_id";
            }
            else
            {
                MessageBox.Show("No events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }

        }


        public void loadFinaneTypes()
        {
            DataTable dt = finance_class.getFinanceTypes();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "value";
                comboBox3.ValueMember = "lookup_id";
            }
            else
            {
                MessageBox.Show("Unknown Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public void loadEntityTypes()
        {
            DataTable dt = finance_class.getEntityTypes();

            if (dt != null && dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "value";
                comboBox1.ValueMember = "lookup_id";

              
            }
            else
            {
                MessageBox.Show("Unknown Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public void loadEntityTypes1()
        {
            DataTable dt = finance_class.getEntityTypes();

            if (dt != null && dt.Rows.Count > 0)
            {
            
                comboBox5.DataSource = dt;
                comboBox5.DisplayMember = "value";
                comboBox5.ValueMember = "lookup_id";
            }
            else
            {
                MessageBox.Show("Unknown Error.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            MessageBox.Show("All Cleared", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itec_id = GlobalData.ItecId.ToString();
            string event_id = comboBox4.SelectedValue.ToString();
            string trasaction_type = comboBox3.SelectedValue.ToString();
            string amount = textBox4.Text.Trim();
            string description = textBox3.Text.Trim();
            string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string from_entity_type = comboBox1.Text;
            string from_entity_id = comboBox1.SelectedValue.ToString();
            string to_entity_type = comboBox5.Text;
            string to_entity_id = comboBox5.SelectedValue.ToString();


            bool flag = finance_class.addTransaction(itec_id, event_id, trasaction_type, amount, description, date, from_entity_type,from_entity_id,to_entity_id,to_entity_type);


            if (flag)
            {
                MessageBox.Show("Transaction added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
               

            }
            else
            {
                MessageBox.Show("Error adding transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
