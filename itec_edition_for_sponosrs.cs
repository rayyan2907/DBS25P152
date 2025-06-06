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
    public partial class itec_edition_for_sponosrs : Form
    {
        public itec_edition_for_sponosrs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void itec_edition_for_sponosrs_Load(object sender, EventArgs e)
        {
            LoadEditions();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login_page login_page = new login_page();
            login_page.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            spnosor_only_page spnosor_only_ = new spnosor_only_page();
            spnosor_only_.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            login_page login_page = new login_page();
            login_page.Show();
            this.Hide();
        }


            private void LoadEditions()
            {
                DataTable editions = itec_edition_class.load_editions();

                if (editions != null && editions.Rows.Count > 0)
                {

                    comboBox1.DataSource = editions;
                    comboBox1.DisplayMember = "year";
                    comboBox1.ValueMember = "itec_id";
                }
                else
                {
                    MessageBox.Show("No editions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
    }
}
