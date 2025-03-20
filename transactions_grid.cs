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
    public partial class transactions_grid : Form
    {
        public transactions_grid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            transaction transaction = new transaction();
            transaction.Show();
        }

        private void transactions_grid_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            DataTable dt = load_data_class.getTransactions(Convert.ToInt32( GlobalData.ItecId));
            if (dt != null && dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }
            else
            {


                MessageBox.Show("No transactions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
   
}
