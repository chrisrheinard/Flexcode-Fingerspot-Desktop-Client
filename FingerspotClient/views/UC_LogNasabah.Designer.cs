namespace FingerspotClient
{
    partial class UC_LogNasabah
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
            this.LBL_CariNasabah = new System.Windows.Forms.Label();
            this.TXT_Search = new System.Windows.Forms.TextBox();
            this.DGV_ListLog = new System.Windows.Forms.DataGridView();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Lihat = new System.Windows.Forms.Button();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_End = new System.Windows.Forms.DateTimePicker();
            this.BTN_Cari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListLog)).BeginInit();
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
            this.LBL_Title.Size = new System.Drawing.Size(274, 46);
            this.LBL_Title.TabIndex = 5;
            this.LBL_Title.Text = "LOG VERIFIKASI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_Cari);
            this.panel1.Controls.Add(this.DTP_End);
            this.panel1.Controls.Add(this.DTP_Start);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LBL_CariNasabah);
            this.panel1.Controls.Add(this.TXT_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 68);
            this.panel1.TabIndex = 6;
            // 
            // LBL_CariNasabah
            // 
            this.LBL_CariNasabah.AutoSize = true;
            this.LBL_CariNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CariNasabah.Location = new System.Drawing.Point(6, 35);
            this.LBL_CariNasabah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_CariNasabah.Name = "LBL_CariNasabah";
            this.LBL_CariNasabah.Size = new System.Drawing.Size(86, 20);
            this.LBL_CariNasabah.TabIndex = 4;
            this.LBL_CariNasabah.Text = "Cari Nama:";
            // 
            // TXT_Search
            // 
            this.TXT_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Search.Location = new System.Drawing.Point(102, 33);
            this.TXT_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_Search.Name = "TXT_Search";
            this.TXT_Search.Size = new System.Drawing.Size(333, 27);
            this.TXT_Search.TabIndex = 0;
            this.TXT_Search.TextChanged += new System.EventHandler(this.TXT_Search_TextChanged);
            // 
            // DGV_ListLog
            // 
            this.DGV_ListLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListLog.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ListLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ListLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_ListLog.Location = new System.Drawing.Point(0, 114);
            this.DGV_ListLog.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_ListLog.Name = "DGV_ListLog";
            this.DGV_ListLog.ReadOnly = true;
            this.DGV_ListLog.RowHeadersVisible = false;
            this.DGV_ListLog.RowHeadersWidth = 51;
            this.DGV_ListLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListLog.Size = new System.Drawing.Size(973, 369);
            this.DGV_ListLog.TabIndex = 9;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(9, 491);
            this.BTN_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(117, 37);
            this.BTN_Refresh.TabIndex = 10;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_Lihat
            // 
            this.BTN_Lihat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Lihat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Lihat.Location = new System.Drawing.Point(134, 491);
            this.BTN_Lihat.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Lihat.Name = "BTN_Lihat";
            this.BTN_Lihat.Size = new System.Drawing.Size(117, 37);
            this.BTN_Lihat.TabIndex = 11;
            this.BTN_Lihat.Text = "Lihat Bukti";
            this.BTN_Lihat.UseVisualStyleBackColor = true;
            this.BTN_Lihat.Click += new System.EventHandler(this.BTN_Lihat_Click);
            // 
            // DTP_Start
            // 
            this.DTP_Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_Start.Location = new System.Drawing.Point(507, 4);
            this.DTP_Start.Name = "DTP_Start";
            this.DTP_Start.Size = new System.Drawing.Size(329, 27);
            this.DTP_Start.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dari:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sampai:";
            // 
            // DTP_End
            // 
            this.DTP_End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DTP_End.Location = new System.Drawing.Point(507, 33);
            this.DTP_End.Name = "DTP_End";
            this.DTP_End.Size = new System.Drawing.Size(329, 27);
            this.DTP_End.TabIndex = 7;
            // 
            // BTN_Cari
            // 
            this.BTN_Cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cari.Location = new System.Drawing.Point(843, 4);
            this.BTN_Cari.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Cari.Name = "BTN_Cari";
            this.BTN_Cari.Size = new System.Drawing.Size(117, 56);
            this.BTN_Cari.TabIndex = 12;
            this.BTN_Cari.Text = "Cari";
            this.BTN_Cari.UseVisualStyleBackColor = true;
            this.BTN_Cari.Click += new System.EventHandler(this.BTN_Cari_Click);
            // 
            // UC_LogNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Lihat);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.DGV_ListLog);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_LogNasabah";
            this.Size = new System.Drawing.Size(973, 536);
            this.Load += new System.EventHandler(this.UC_LogNasabah_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_CariNasabah;
        private System.Windows.Forms.TextBox TXT_Search;
        private System.Windows.Forms.DataGridView DGV_ListLog;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Lihat;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.DateTimePicker DTP_End;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Cari;
    }
}
