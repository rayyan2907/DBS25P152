using Microsoft.Reporting.WinForms;
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
    public partial class leaderBoard : Form
    {
        public leaderBoard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void leaderBoard_Load(object sender, EventArgs e)
        {
            loadLeaderBoard();
        }

        public void loadLeaderBoard()
        {

            try
            {


                DataTable dt = load_data_class.Leaderboard(Convert.ToInt32(GlobalData.ItecId));

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
