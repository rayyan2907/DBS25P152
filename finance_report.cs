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
    public partial class finance_report : Form
    {
        public finance_report()
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


        public void loadFinances()
        {

            try
            {


                DataTable dt1 = load_data_class.FinanceRep(Convert.ToInt32(GlobalData.ItecId));
                DataTable dt2 = load_data_class.FinanceExpenseRep(Convert.ToInt32(GlobalData.ItecId));

                // Set Processing Mode
                reportViewer1.ProcessingMode = ProcessingMode.Local;

                // Clear Existing DataSources
                reportViewer1.LocalReport.DataSources.Clear();

                // Add Data Sources
                ReportDataSource rds1 = new ReportDataSource("DataSet1", dt1);
                ReportDataSource rds2 = new ReportDataSource("DataSet2", dt2);

                reportViewer1.LocalReport.DataSources.Add(rds1);
                reportViewer1.LocalReport.DataSources.Add(rds2);

                // Refresh Report
                reportViewer1.RefreshReport();




              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void finance_report_Load(object sender, EventArgs e)
        {
            loadFinances();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
