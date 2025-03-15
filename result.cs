using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//results saved in ranking and rankings u=in results
//both pages are swapped


namespace Itec_Mangement
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();

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

        private void button1_Click(object sender, EventArgs e)
        {

            rankings rankings = new rankings();
            rankings.TopLevel = false;
            panel3.Controls.Add(rankings);
            rankings.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            competetion_results competetion_Results = new competetion_results();
            competetion_Results.TopLevel = false;
            panel3.Controls.Add(competetion_Results);
            competetion_Results.Show();
        }

        private void result_Load(object sender, EventArgs e)
        {

        }
    }
}
