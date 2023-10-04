namespace AtYarisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            saha = new Panel();
            label1 = new Label();
            bitis = new Panel();
            at2 = new PictureBox();
            at3 = new PictureBox();
            at1 = new PictureBox();
            btnBaslat = new Button();
            lblDurum = new Label();
            saha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)at2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)at1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // saha
            // 
            saha.BackColor = Color.LimeGreen;
            saha.Controls.Add(label1);
            saha.Controls.Add(bitis);
            saha.Controls.Add(at2);
            saha.Controls.Add(at3);
            saha.Controls.Add(at1);
            saha.Location = new Point(12, 82);
            saha.Name = "saha";
            saha.Size = new Size(429, 286);
            saha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(73, 79);
            label1.Name = "label1";
            label1.Size = new Size(0, 37);
            label1.TabIndex = 4;
            // 
            // bitis
            // 
            bitis.BackColor = Color.DarkRed;
            bitis.Location = new Point(380, 0);
            bitis.Name = "bitis";
            bitis.Size = new Size(10, 287);
            bitis.TabIndex = 0;
            // 
            // at2
            // 
            at2.Image = Properties.Resources.at4;
            at2.Location = new Point(0, 101);
            at2.Name = "at2";
            at2.Size = new Size(100, 63);
            at2.SizeMode = PictureBoxSizeMode.Zoom;
            at2.TabIndex = 3;
            at2.TabStop = false;
            at2.Tag = "2";
            // 
            // at3
            // 
            at3.Image = Properties.Resources.at8;
            at3.Location = new Point(0, 201);
            at3.Name = "at3";
            at3.Size = new Size(100, 63);
            at3.SizeMode = PictureBoxSizeMode.Zoom;
            at3.TabIndex = 2;
            at3.TabStop = false;
            at3.Tag = "3";
            // 
            // at1
            // 
            at1.Image = Properties.Resources.at2;
            at1.Location = new Point(0, 13);
            at1.Name = "at1";
            at1.Size = new Size(100, 63);
            at1.SizeMode = PictureBoxSizeMode.Zoom;
            at1.TabIndex = 1;
            at1.TabStop = false;
            at1.Tag = "1";
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(12, 374);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(429, 48);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "BAŞLAT";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // lblDurum
            // 
            lblDurum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDurum.Location = new Point(12, 5);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(430, 65);
            lblDurum.TabIndex = 2;
            lblDurum.Text = "Atlar yarışa hazır.";
            lblDurum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 436);
            Controls.Add(lblDurum);
            Controls.Add(btnBaslat);
            Controls.Add(saha);
            Name = "Form1";
            Text = "At Yarışı";
            Load += Form1_Load;
            saha.ResumeLayout(false);
            saha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)at2).EndInit();
            ((System.ComponentModel.ISupportInitialize)at3).EndInit();
            ((System.ComponentModel.ISupportInitialize)at1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel saha;
        private PictureBox at1;
        private Panel bitis;
        private PictureBox at2;
        private PictureBox at3;
        private Button btnBaslat;
        private Label label1;
        private Label lblDurum;
    }
}