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
            this.DGV_ListCustomer = new System.Windows.Forms.DataGridView();
            this.BTN_UbahData = new System.Windows.Forms.Button();
            this.BTN_HapusData = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListCustomer)).BeginInit();
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
            this.LBL_Title.Size = new System.Drawing.Size(325, 46);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "DAFTAR NASABAH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_CariNasabah);
            this.panel1.Controls.Add(this.TXT_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 38);
            this.panel1.TabIndex = 5;
            // 
            // LBL_CariNasabah
            // 
            this.LBL_CariNasabah.AutoSize = true;
            this.LBL_CariNasabah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CariNasabah.Location = new System.Drawing.Point(5, 6);
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
            this.TXT_Search.Location = new System.Drawing.Point(101, 4);
            this.TXT_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_Search.Name = "TXT_Search";
            this.TXT_Search.Size = new System.Drawing.Size(333, 27);
            this.TXT_Search.TabIndex = 0;
            this.TXT_Search.TextChanged += new System.EventHandler(this.TXT_Search_TextChanged);
            // 
            // DGV_ListCustomer
            // 
            this.DGV_ListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ListCustomer.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ListCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_ListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ListCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_ListCustomer.Location = new System.Drawing.Point(0, 84);
            this.DGV_ListCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_ListCustomer.Name = "DGV_ListCustomer";
            this.DGV_ListCustomer.ReadOnly = true;
            this.DGV_ListCustomer.RowHeadersVisible = false;
            this.DGV_ListCustomer.RowHeadersWidth = 51;
            this.DGV_ListCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ListCustomer.Size = new System.Drawing.Size(773, 399);
            this.DGV_ListCustomer.TabIndex = 6;
            // 
            // BTN_UbahData
            // 
            this.BTN_UbahData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UbahData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UbahData.Location = new System.Drawing.Point(9, 490);
            this.BTN_UbahData.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_UbahData.Name = "BTN_UbahData";
            this.BTN_UbahData.Size = new System.Drawing.Size(117, 37);
            this.BTN_UbahData.TabIndex = 7;
            this.BTN_UbahData.Text = "Ubah Data";
            this.BTN_UbahData.UseVisualStyleBackColor = true;
            this.BTN_UbahData.Click += new System.EventHandler(this.BTN_UbahData_Click);
            // 
            // BTN_HapusData
            // 
            this.BTN_HapusData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_HapusData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HapusData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_HapusData.Location = new System.Drawing.Point(135, 490);
            this.BTN_HapusData.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_HapusData.Name = "BTN_HapusData";
            this.BTN_HapusData.Size = new System.Drawing.Size(117, 37);
            this.BTN_HapusData.TabIndex = 8;
            this.BTN_HapusData.Text = "Hapus Data";
            this.BTN_HapusData.UseVisualStyleBackColor = true;
            this.BTN_HapusData.Click += new System.EventHandler(this.BTN_HapusData_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(260, 490);
            this.BTN_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(117, 37);
            this.BTN_Refresh.TabIndex = 9;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // UC_ListNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_HapusData);
            this.Controls.Add(this.BTN_UbahData);
            this.Controls.Add(this.DGV_ListCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ListNasabah";
            this.Size = new System.Drawing.Size(773, 538);
            this.Load += new System.EventHandler(this.UC_ListNasabah_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ListCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TXT_Search;
        private System.Windows.Forms.Label LBL_CariNasabah;
        private System.Windows.Forms.DataGridView DGV_ListCustomer;
        private System.Windows.Forms.Button BTN_UbahData;
        private System.Windows.Forms.Button BTN_HapusData;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}
