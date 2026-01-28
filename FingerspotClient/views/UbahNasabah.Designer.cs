namespace FingerspotClient.views
{
    partial class UbahNasabah
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Batal = new System.Windows.Forms.Button();
            this.LBL_DeviceName = new System.Windows.Forms.Label();
            this.BTN_Ubah = new System.Windows.Forms.Button();
            this.TXT_ID = new System.Windows.Forms.TextBox();
            this.TXT_Nama = new System.Windows.Forms.TextBox();
            this.LBL_SN = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Controls.Add(this.ButtonExit);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(343, 48);
            this.PanelHeader.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(178, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ubah Data Nasabah";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ButtonExit.Location = new System.Drawing.Point(282, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(61, 48);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "🗙";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Batal);
            this.groupBox1.Controls.Add(this.LBL_DeviceName);
            this.groupBox1.Controls.Add(this.BTN_Ubah);
            this.groupBox1.Controls.Add(this.TXT_ID);
            this.groupBox1.Controls.Add(this.TXT_Nama);
            this.groupBox1.Controls.Add(this.LBL_SN);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(314, 246);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA NASABAH";
            // 
            // BTN_Batal
            // 
            this.BTN_Batal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Batal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Batal.Location = new System.Drawing.Point(48, 176);
            this.BTN_Batal.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Batal.Name = "BTN_Batal";
            this.BTN_Batal.Size = new System.Drawing.Size(117, 37);
            this.BTN_Batal.TabIndex = 22;
            this.BTN_Batal.Text = "Batal";
            this.BTN_Batal.UseVisualStyleBackColor = true;
            this.BTN_Batal.Click += new System.EventHandler(this.BTN_Batal_Click);
            // 
            // LBL_DeviceName
            // 
            this.LBL_DeviceName.AutoSize = true;
            this.LBL_DeviceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DeviceName.Location = new System.Drawing.Point(8, 39);
            this.LBL_DeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_DeviceName.Name = "LBL_DeviceName";
            this.LBL_DeviceName.Size = new System.Drawing.Size(153, 20);
            this.LBL_DeviceName.TabIndex = 13;
            this.LBL_DeviceName.Text = "No Rekening / ID CBS";
            // 
            // BTN_Ubah
            // 
            this.BTN_Ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Ubah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ubah.Location = new System.Drawing.Point(173, 176);
            this.BTN_Ubah.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Ubah.Name = "BTN_Ubah";
            this.BTN_Ubah.Size = new System.Drawing.Size(117, 37);
            this.BTN_Ubah.TabIndex = 9;
            this.BTN_Ubah.Text = "Ubah";
            this.BTN_Ubah.UseVisualStyleBackColor = true;
            this.BTN_Ubah.Click += new System.EventHandler(this.BTN_Ubah_Click);
            // 
            // TXT_ID
            // 
            this.TXT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_ID.Location = new System.Drawing.Point(12, 62);
            this.TXT_ID.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_ID.Name = "TXT_ID";
            this.TXT_ID.Size = new System.Drawing.Size(278, 27);
            this.TXT_ID.TabIndex = 12;
            // 
            // TXT_Nama
            // 
            this.TXT_Nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Nama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Nama.Location = new System.Drawing.Point(12, 130);
            this.TXT_Nama.Margin = new System.Windows.Forms.Padding(4);
            this.TXT_Nama.Name = "TXT_Nama";
            this.TXT_Nama.Size = new System.Drawing.Size(278, 27);
            this.TXT_Nama.TabIndex = 14;
            // 
            // LBL_SN
            // 
            this.LBL_SN.AutoSize = true;
            this.LBL_SN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SN.Location = new System.Drawing.Point(8, 108);
            this.LBL_SN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_SN.Name = "LBL_SN";
            this.LBL_SN.Size = new System.Drawing.Size(49, 20);
            this.LBL_SN.TabIndex = 15;
            this.LBL_SN.Text = "Nama";
            // 
            // UbahNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 319);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahNasabah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UbahNasabah";
            this.PanelHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Batal;
        private System.Windows.Forms.Label LBL_DeviceName;
        private System.Windows.Forms.Button BTN_Ubah;
        private System.Windows.Forms.TextBox TXT_ID;
        private System.Windows.Forms.TextBox TXT_Nama;
        private System.Windows.Forms.Label LBL_SN;
    }
}