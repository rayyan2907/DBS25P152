﻿using System;
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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void registration_Load(object sender, EventArgs e)
        {

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

        private void button9_Click(object sender, EventArgs e)
        {
            itec_edition itec = new itec_edition();
            this.Hide();
            itec.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainpage mainpage = new mainpage();
            mainpage.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            registration_student registration = new registration_student();
            registration.TopLevel = false;
            panel3.Controls.Add(registration);
            registration.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            registration_student registration_Student = new registration_student(); 
            registration_Student.TopLevel = false;
            panel3.Controls.Add(registration_Student);
            registration_Student.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            team_add team_Add = new team_add();
            team_Add.TopLevel = false;
            panel3.Controls.Add(team_Add);
            team_Add.Show();
        }
    }
}
