using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itec_Mangement
{
   
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            SetYear(GlobalData.ItecYear);
            SetItecId(GlobalData.ItecId);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            //events events = new events();
            //events.Show();


            events_datagrid events_New = new events_datagrid();
            events_New.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            finance finance = new finance();
            this.Hide();
            finance.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result result = new result();
            this.Hide();
            result.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            venues_grid venues_Grid = new venues_grid();
            venues_Grid.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            report report = new report();
            this.Hide();
            report.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            itec_edition itec = new itec_edition();
            this.Hide();
            itec.Show();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //registration registration = new registration();


            //registration.Show();


            registration_new registration_New  = new registration_new();
            registration_New.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide() ;
            //rolls rolls = new rolls();
            //rolls.Show();


            committees_grid committees_Grid = new committees_grid();
            committees_Grid.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            duty_grid duty_grid = new duty_grid();
            duty_grid.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }
        public void SetYear(string year)
        {
            GlobalData.ItecYear = year;
            label9.Text = "ITEC: " + year;
        }
        public void SetItecId(string id)
        {
            GlobalData.ItecId = id;
            //MessageBox.Show(GlobalData.ItecId);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    public static class GlobalData
    {
        public static string ItecYear { get; set; }
        public static string ItecId { get; set; } 

    }

}
