namespace FingerspotClient
{
    partial class UC_ListAlat
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
            this.DGV_DeviceList = new System.Windows.Forms.DataGridView();
            this.BTN_Hapus = new System.Windows.Forms.Button();
            this.PanelTombol = new System.Windows.Forms.Panel();
            this.BTN_Tambah = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeviceList)).BeginInit();
            this.PanelTombol.SuspendLayout();
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
            this.LBL_Title.Size = new System.Drawing.Size(524, 46);
            this.LBL_Title.TabIndex = 6;
            this.LBL_Title.Text = "LIST ALAT PEREKAM SIDIK JARI";
            // 
            // DGV_DeviceList
            // 
            this.DGV_DeviceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DeviceList.BackgroundColor = System.Drawing.Color.White;
            this.DGV_DeviceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_DeviceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DeviceList.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_DeviceList.Location = new System.Drawing.Point(0, 46);
            this.DGV_DeviceList.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_DeviceList.Name = "DGV_DeviceList";
            this.DGV_DeviceList.ReadOnly = true;
            this.DGV_DeviceList.RowHeadersVisible = false;
            this.DGV_DeviceList.RowHeadersWidth = 51;
            this.DGV_DeviceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DeviceList.Size = new System.Drawing.Size(773, 399);
            this.DGV_DeviceList.TabIndex = 7;
            // 
            // BTN_Hapus
            // 
            this.BTN_Hapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Hapus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Hapus.Location = new System.Drawing.Point(135, 7);
            this.BTN_Hapus.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Hapus.Name = "BTN_Hapus";
            this.BTN_Hapus.Size = new System.Drawing.Size(117, 37);
            this.BTN_Hapus.TabIndex = 10;
            this.BTN_Hapus.Text = "Hapus";
            this.BTN_Hapus.UseVisualStyleBackColor = true;
            // 
            // PanelTombol
            // 
            this.PanelTombol.Controls.Add(this.BTN_Refresh);
            this.PanelTombol.Controls.Add(this.BTN_Hapus);
            this.PanelTombol.Controls.Add(this.BTN_Tambah);
            this.PanelTombol.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTombol.Location = new System.Drawing.Point(0, 445);
            this.PanelTombol.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTombol.Name = "PanelTombol";
            this.PanelTombol.Size = new System.Drawing.Size(773, 50);
            this.PanelTombol.TabIndex = 11;
            // 
            // BTN_Tambah
            // 
            this.BTN_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Tambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Tambah.Location = new System.Drawing.Point(9, 7);
            this.BTN_Tambah.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Tambah.Name = "BTN_Tambah";
            this.BTN_Tambah.Size = new System.Drawing.Size(117, 37);
            this.BTN_Tambah.TabIndex = 9;
            this.BTN_Tambah.Text = "Tambah";
            this.BTN_Tambah.UseVisualStyleBackColor = true;
            this.BTN_Tambah.Click += new System.EventHandler(this.BTN_Tambah_Click);
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(260, 7);
            this.BTN_Refresh.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(117, 37);
            this.BTN_Refresh.TabIndex = 12;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // UC_ListAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTombol);
            this.Controls.Add(this.DGV_DeviceList);
            this.Controls.Add(this.LBL_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_ListAlat";
            this.Size = new System.Drawing.Size(773, 501);
            this.Load += new System.EventHandler(this.UC_ListAlat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DeviceList)).EndInit();
            this.PanelTombol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.DataGridView DGV_DeviceList;
        private System.Windows.Forms.Button BTN_Hapus;
        private System.Windows.Forms.Panel PanelTombol;
        private System.Windows.Forms.Button BTN_Tambah;
        private System.Windows.Forms.Button BTN_Refresh;
    }
}
