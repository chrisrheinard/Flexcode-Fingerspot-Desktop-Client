namespace FingerspotClient
{
    partial class UC_VerifNasabah
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_WaktuVerif = new System.Windows.Forms.TextBox();
            this.LBL_WaktuVerif = new System.Windows.Forms.Label();
            this.TXT_IdNasabah = new System.Windows.Forms.TextBox();
            this.LBL_IdNasabah = new System.Windows.Forms.Label();
            this.TXT_NamaNasabah = new System.Windows.Forms.TextBox();
            this.LBL_NamaNasabah = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(0, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(298, 37);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "VERIFIKASI NASABAH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 290);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Silakan Tempelkan Jari...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_WaktuVerif);
            this.groupBox1.Controls.Add(this.LBL_WaktuVerif);
            this.groupBox1.Controls.Add(this.TXT_IdNasabah);
            this.groupBox1.Controls.Add(this.LBL_IdNasabah);
            this.groupBox1.Controls.Add(this.TXT_NamaNasabah);
            this.groupBox1.Controls.Add(this.LBL_NamaNasabah);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(269, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 224);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA TERDETEKSI";
            // 
            // TXT_WaktuVerif
            // 
            this.TXT_WaktuVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_WaktuVerif.Enabled = false;
            this.TXT_WaktuVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_WaktuVerif.Location = new System.Drawing.Point(9, 177);
            this.TXT_WaktuVerif.Name = "TXT_WaktuVerif";
            this.TXT_WaktuVerif.Size = new System.Drawing.Size(245, 21);
            this.TXT_WaktuVerif.TabIndex = 6;
            this.TXT_WaktuVerif.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBL_WaktuVerif
            // 
            this.LBL_WaktuVerif.AutoSize = true;
            this.LBL_WaktuVerif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WaktuVerif.Location = new System.Drawing.Point(6, 159);
            this.LBL_WaktuVerif.Name = "LBL_WaktuVerif";
            this.LBL_WaktuVerif.Size = new System.Drawing.Size(98, 15);
            this.LBL_WaktuVerif.TabIndex = 5;
            this.LBL_WaktuVerif.Text = "Waktu Verifikasi";
            this.LBL_WaktuVerif.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_IdNasabah
            // 
            this.TXT_IdNasabah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_IdNasabah.Enabled = false;
            this.TXT_IdNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_IdNasabah.Location = new System.Drawing.Point(9, 54);
            this.TXT_IdNasabah.Name = "TXT_IdNasabah";
            this.TXT_IdNasabah.Size = new System.Drawing.Size(245, 21);
            this.TXT_IdNasabah.TabIndex = 4;
            // 
            // LBL_IdNasabah
            // 
            this.LBL_IdNasabah.AutoSize = true;
            this.LBL_IdNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IdNasabah.Location = new System.Drawing.Point(6, 36);
            this.LBL_IdNasabah.Name = "LBL_IdNasabah";
            this.LBL_IdNasabah.Size = new System.Drawing.Size(69, 15);
            this.LBL_IdNasabah.TabIndex = 3;
            this.LBL_IdNasabah.Text = "ID Nasabah";
            // 
            // TXT_NamaNasabah
            // 
            this.TXT_NamaNasabah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_NamaNasabah.Enabled = false;
            this.TXT_NamaNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_NamaNasabah.Location = new System.Drawing.Point(9, 114);
            this.TXT_NamaNasabah.Name = "TXT_NamaNasabah";
            this.TXT_NamaNasabah.Size = new System.Drawing.Size(245, 21);
            this.TXT_NamaNasabah.TabIndex = 1;
            // 
            // LBL_NamaNasabah
            // 
            this.LBL_NamaNasabah.AutoSize = true;
            this.LBL_NamaNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NamaNasabah.Location = new System.Drawing.Point(6, 96);
            this.LBL_NamaNasabah.Name = "LBL_NamaNasabah";
            this.LBL_NamaNasabah.Size = new System.Drawing.Size(88, 15);
            this.LBL_NamaNasabah.TabIndex = 0;
            this.LBL_NamaNasabah.Text = "Nama Nasabah";
            // 
            // UC_VerifNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_Title);
            this.Name = "UC_VerifNasabah";
            this.Size = new System.Drawing.Size(580, 335);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_IdNasabah;
        private System.Windows.Forms.Label LBL_IdNasabah;
        private System.Windows.Forms.TextBox TXT_NamaNasabah;
        private System.Windows.Forms.Label LBL_NamaNasabah;
        private System.Windows.Forms.TextBox TXT_WaktuVerif;
        private System.Windows.Forms.Label LBL_WaktuVerif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
