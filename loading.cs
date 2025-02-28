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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
         
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void panel1_Paint(object sender, PaintEventArgs e)
        {
            await Task.Delay(50);
            panel1.Width += 6 ;
            if (panel1.Width >= 599) {
                timer1.Stop();
               
                

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void loading_Load(object sender, EventArgs e)
        {

        }
    }
}
