namespace FingerspotClient
{
    partial class UC_ListNasabah
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
            this.DGV_ListNasabah = new System.Windows.Forms.DataGridView();
            this.BTN_UbahData = new System.Windows.Forms.Button();
            this.BTN_HapusData = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListNasabah)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(0, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(259, 37);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "DAFTAR NASABAH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_CariNasabah);
            this.panel1.Controls.Add(this.TXT_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 31);
            this.panel1.TabIndex = 5;
            // 
            // LBL_CariNasabah
            // 
            this.LBL_CariNasabah.AutoSize = true;
            this.LBL_CariNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CariNasabah.Location = new System.Drawing.Point(4, 5);
            this.LBL_CariNasabah.Name = "LBL_CariNasabah";
            this.LBL_CariNasabah.Size = new System.Drawing.Size(66, 15);
            this.LBL_CariNasabah.TabIndex = 4;
            this.LBL_CariNasabah.Text = "Cari Nama:";
            // 
            // TXT_Search
            // 
            this.TXT_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Search.Location = new System.Drawing.Point(76, 3);
            this.TXT_Search.Name = "TXT_Search";
            this.TXT_Search.Size = new System.Drawing.Size(250, 23);
            this.TXT_Search.TabIndex = 0;
            this.TXT_Search.TextChanged += new System.EventHandler(this.TXT_Search_TextChanged);
            // 
            // DGV_ListNasabah
            // 
            this.DGV_ListNasabah.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListNasabah.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ListNasabah.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ListNasabah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListNasabah.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_ListNasabah.Location = new System.Drawing.Point(0, 68);
            this.DGV_ListNasabah.Name = "DGV_ListNasabah";
            this.DGV_ListNasabah.ReadOnly = true;
            this.DGV_ListNasabah.RowHeadersVisible = false;
            this.DGV_ListNasabah.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListNasabah.Size = new System.Drawing.Size(580, 324);
            this.DGV_ListNasabah.TabIndex = 6;
            // 
            // BTN_UbahData
            // 
            this.BTN_UbahData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UbahData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UbahData.Location = new System.Drawing.Point(7, 398);
            this.BTN_UbahData.Name = "BTN_UbahData";
            this.BTN_UbahData.Size = new System.Drawing.Size(88, 30);
            this.BTN_UbahData.TabIndex = 7;
            this.BTN_UbahData.Text = "Ubah Data";
            this.BTN_UbahData.UseVisualStyleBackColor = true;
            // 
            // BTN_HapusData
            // 
            this.BTN_HapusData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_HapusData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HapusData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HapusData.Location = new System.Drawing.Point(101, 398);
            this.BTN_HapusData.Name = "BTN_HapusData";
            this.BTN_HapusData.Size = new System.Drawing.Size(88, 30);
            this.BTN_HapusData.TabIndex = 8;
            this.BTN_HapusData.Text = "Hapus Data";
            this.BTN_HapusData.UseVisualStyleBackColor = true;
            // 
            // UC_ListNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_HapusData);
            this.Controls.Add(this.BTN_UbahData);
            this.Controls.Add(this.DGV_ListNasabah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_Title);
            this.Name = "UC_ListNasabah";
            this.Size = new System.Drawing.Size(580, 437);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListNasabah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_Search;
        private System.Windows.Forms.Label LBL_CariNasabah;
        private System.Windows.Forms.DataGridView DGV_ListNasabah;
        private System.Windows.Forms.Button BTN_UbahData;
        private System.Windows.Forms.Button BTN_HapusData;
    }
}
