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
            this.LBL_Status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Verifikasi = new System.Windows.Forms.Button();
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
            this.LBL_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(374, 46);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "VERIFIKASI NASABAH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_Status);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 357);
            this.panel1.TabIndex = 5;
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Status.Location = new System.Drawing.Point(159, 323);
            this.LBL_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(34, 20);
            this.LBL_Status.TabIndex = 7;
            this.LBL_Status.Text = "Idle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(9, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 315);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Cancel);
            this.groupBox1.Controls.Add(this.BTN_Verifikasi);
            this.groupBox1.Controls.Add(this.TXT_WaktuVerif);
            this.groupBox1.Controls.Add(this.LBL_WaktuVerif);
            this.groupBox1.Controls.Add(this.TXT_IdNasabah);
            this.groupBox1.Controls.Add(this.LBL_IdNasabah);
            this.groupBox1.Controls.Add(this.TXT_NamaNasabah);
            this.groupBox1.Controls.Add(this.LBL_NamaNasabah);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(359, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(363, 315);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA TERDETEKSI";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Enabled = false;
            this.BTN_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancel.Location = new System.Drawing.Point(12, 268);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(326, 37);
            this.BTN_Cancel.TabIndex = 7;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Verifikasi
            // 
            this.BTN_Verifikasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Verifikasi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Verifikasi.Location = new System.Drawing.Point(12, 223);
            this.BTN_Verifikasi.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Verifikasi.Name = "BTN_Verifikasi";
            this.BTN_Verifikasi.Size = new System.Drawing.Size(326, 37);
            this.BTN_Verifikasi.TabIndex = 6;
            this.BTN_Verifikasi.Text = "Verifikasi";
            this.BTN_Verifikasi.UseVisualStyleBackColor = true;
            this.BTN_Verifikasi.Click += new System.EventHandler(this.BTN_Verifikasi_Click);
            // 
            // TXT_WaktuVerif
            // 
            this.TXT_WaktuVerif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_WaktuVerif.Enabled = false;
            this.TXT_WaktuVerif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_WaktuVerif.Location = new System.Drawing.Point(12, 166);
            this.TXT_WaktuVerif.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_WaktuVerif.Name = "TXT_WaktuVerif";
            this.TXT_WaktuVerif.Size = new System.Drawing.Size(326, 24);
            this.TXT_WaktuVerif.TabIndex = 6;
            this.TXT_WaktuVerif.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBL_WaktuVerif
            // 
            this.LBL_WaktuVerif.AutoSize = true;
            this.LBL_WaktuVerif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WaktuVerif.Location = new System.Drawing.Point(8, 144);
            this.LBL_WaktuVerif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_WaktuVerif.Name = "LBL_WaktuVerif";
            this.LBL_WaktuVerif.Size = new System.Drawing.Size(122, 20);
            this.LBL_WaktuVerif.TabIndex = 5;
            this.LBL_WaktuVerif.Text = "Waktu Verifikasi";
            this.LBL_WaktuVerif.Click += new System.EventHandler(this.label1_Click);
            // 
            // TXT_IdNasabah
            // 
            this.TXT_IdNasabah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_IdNasabah.Enabled = false;
            this.TXT_IdNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_IdNasabah.Location = new System.Drawing.Point(12, 66);
            this.TXT_IdNasabah.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_IdNasabah.Name = "TXT_IdNasabah";
            this.TXT_IdNasabah.Size = new System.Drawing.Size(326, 24);
            this.TXT_IdNasabah.TabIndex = 4;
            // 
            // LBL_IdNasabah
            // 
            this.LBL_IdNasabah.AutoSize = true;
            this.LBL_IdNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_IdNasabah.Location = new System.Drawing.Point(8, 44);
            this.LBL_IdNasabah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_IdNasabah.Name = "LBL_IdNasabah";
            this.LBL_IdNasabah.Size = new System.Drawing.Size(90, 20);
            this.LBL_IdNasabah.TabIndex = 3;
            this.LBL_IdNasabah.Text = "ID Nasabah";
            // 
            // TXT_NamaNasabah
            // 
            this.TXT_NamaNasabah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_NamaNasabah.Enabled = false;
            this.TXT_NamaNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_NamaNasabah.Location = new System.Drawing.Point(12, 116);
            this.TXT_NamaNasabah.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_NamaNasabah.Name = "TXT_NamaNasabah";
            this.TXT_NamaNasabah.Size = new System.Drawing.Size(326, 24);
            this.TXT_NamaNasabah.TabIndex = 1;
            // 
            // LBL_NamaNasabah
            // 
            this.LBL_NamaNasabah.AutoSize = true;
            this.LBL_NamaNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NamaNasabah.Location = new System.Drawing.Point(8, 94);
            this.LBL_NamaNasabah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_NamaNasabah.Name = "LBL_NamaNasabah";
            this.LBL_NamaNasabah.Size = new System.Drawing.Size(116, 20);
            this.LBL_NamaNasabah.TabIndex = 0;
            this.LBL_NamaNasabah.Text = "Nama Nasabah";
            // 
            // UC_VerifNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_VerifNasabah";
            this.Size = new System.Drawing.Size(773, 412);
            this.Load += new System.EventHandler(this.UC_VerifNasabah_Load);
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
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.Button BTN_Verifikasi;
        private System.Windows.Forms.Button BTN_Cancel;
    }
}
