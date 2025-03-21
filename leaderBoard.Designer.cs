namespace Itec_Mangement
{
    partial class leaderBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(55)))));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Itec_Mangement.leaderBoard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1127, 583);
            this.reportViewer1.TabIndex = 54;
            // 
            // button12
            // 
            this.button12.Image = global::Itec_Mangement.Properties.Resources.image_invert__1___1_;
            this.button12.Location = new System.Drawing.Point(1070, 14);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 26);
            this.button12.TabIndex = 57;
            this.button12.Text = "]";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Image = global::Itec_Mangement.Properties.Resources.image_invert__5_1;
            this.button13.Location = new System.Drawing.Point(19, 14);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(28, 26);
            this.button13.TabIndex = 56;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Itec_Mangement.Properties.Resources.Yellow_and_Pink_Fruit_Bold_Illustrative_Food_Product_Logo__2___2_;
            this.pictureBox1.Location = new System.Drawing.Point(409, -91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 275);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // leaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1116, 679);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.pictureBox1);
            this.Name = "leaderBoard";
            this.Text = "leaderBoard";
            this.Load += new System.EventHandler(this.leaderBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}