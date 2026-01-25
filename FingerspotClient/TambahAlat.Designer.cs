namespace FingerspotClient
{
    partial class FormTambahAlat
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
            this.LBL_DeviceName = new System.Windows.Forms.Label();
            this.BTN_Tambah = new System.Windows.Forms.Button();
            this.LBL_VK = new System.Windows.Forms.Label();
            this.TXT_DeviceName = new System.Windows.Forms.TextBox();
            this.TXT_VK = new System.Windows.Forms.TextBox();
            this.TXT_SN = new System.Windows.Forms.TextBox();
            this.LBL_AC = new System.Windows.Forms.Label();
            this.LBL_SN = new System.Windows.Forms.Label();
            this.TXT_AC = new System.Windows.Forms.TextBox();
            this.TXT_VC = new System.Windows.Forms.TextBox();
            this.LBL_VC = new System.Windows.Forms.Label();
            this.BTN_Batal = new System.Windows.Forms.Button();
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
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(500, 39);
            this.PanelHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tambah Alat Sidik Jari";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ButtonExit.Location = new System.Drawing.Point(454, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(46, 39);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "🗙";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Batal);
            this.groupBox1.Controls.Add(this.LBL_DeviceName);
            this.groupBox1.Controls.Add(this.BTN_Tambah);
            this.groupBox1.Controls.Add(this.LBL_VK);
            this.groupBox1.Controls.Add(this.TXT_DeviceName);
            this.groupBox1.Controls.Add(this.TXT_VK);
            this.groupBox1.Controls.Add(this.TXT_SN);
            this.groupBox1.Controls.Add(this.LBL_AC);
            this.groupBox1.Controls.Add(this.LBL_SN);
            this.groupBox1.Controls.Add(this.TXT_AC);
            this.groupBox1.Controls.Add(this.TXT_VC);
            this.groupBox1.Controls.Add(this.LBL_VC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 245);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAMBAH ALAT PEREKAM SIDIK JARI BARU";
            // 
            // LBL_DeviceName
            // 
            this.LBL_DeviceName.AutoSize = true;
            this.LBL_DeviceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DeviceName.Location = new System.Drawing.Point(6, 32);
            this.LBL_DeviceName.Name = "LBL_DeviceName";
            this.LBL_DeviceName.Size = new System.Drawing.Size(77, 15);
            this.LBL_DeviceName.TabIndex = 13;
            this.LBL_DeviceName.Text = "Device Name";
            // 
            // BTN_Tambah
            // 
            this.BTN_Tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Tambah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Tambah.Location = new System.Drawing.Point(378, 206);
            this.BTN_Tambah.Name = "BTN_Tambah";
            this.BTN_Tambah.Size = new System.Drawing.Size(88, 30);
            this.BTN_Tambah.TabIndex = 9;
            this.BTN_Tambah.Text = "Tambah";
            this.BTN_Tambah.UseVisualStyleBackColor = true;
            // 
            // LBL_VK
            // 
            this.LBL_VK.AutoSize = true;
            this.LBL_VK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VK.Location = new System.Drawing.Point(247, 150);
            this.LBL_VK.Name = "LBL_VK";
            this.LBL_VK.Size = new System.Drawing.Size(151, 15);
            this.LBL_VK.TabIndex = 21;
            this.LBL_VK.Text = "Device Verification Key (VK)";
            // 
            // TXT_DeviceName
            // 
            this.TXT_DeviceName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DeviceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_DeviceName.Location = new System.Drawing.Point(9, 50);
            this.TXT_DeviceName.Name = "TXT_DeviceName";
            this.TXT_DeviceName.Size = new System.Drawing.Size(209, 23);
            this.TXT_DeviceName.TabIndex = 12;
            // 
            // TXT_VK
            // 
            this.TXT_VK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_VK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VK.Location = new System.Drawing.Point(250, 168);
            this.TXT_VK.Name = "TXT_VK";
            this.TXT_VK.Size = new System.Drawing.Size(209, 23);
            this.TXT_VK.TabIndex = 20;
            // 
            // TXT_SN
            // 
            this.TXT_SN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SN.Location = new System.Drawing.Point(9, 106);
            this.TXT_SN.Name = "TXT_SN";
            this.TXT_SN.Size = new System.Drawing.Size(209, 23);
            this.TXT_SN.TabIndex = 14;
            // 
            // LBL_AC
            // 
            this.LBL_AC.AutoSize = true;
            this.LBL_AC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AC.Location = new System.Drawing.Point(6, 150);
            this.LBL_AC.Name = "LBL_AC";
            this.LBL_AC.Size = new System.Drawing.Size(157, 15);
            this.LBL_AC.TabIndex = 19;
            this.LBL_AC.Text = "Device Activation Code (AC)";
            // 
            // LBL_SN
            // 
            this.LBL_SN.AutoSize = true;
            this.LBL_SN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SN.Location = new System.Drawing.Point(6, 88);
            this.LBL_SN.Name = "LBL_SN";
            this.LBL_SN.Size = new System.Drawing.Size(146, 15);
            this.LBL_SN.TabIndex = 15;
            this.LBL_SN.Text = "Device Serial Number (SN)";
            // 
            // TXT_AC
            // 
            this.TXT_AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_AC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AC.Location = new System.Drawing.Point(9, 168);
            this.TXT_AC.Name = "TXT_AC";
            this.TXT_AC.Size = new System.Drawing.Size(209, 23);
            this.TXT_AC.TabIndex = 18;
            // 
            // TXT_VC
            // 
            this.TXT_VC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_VC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VC.Location = new System.Drawing.Point(250, 106);
            this.TXT_VC.Name = "TXT_VC";
            this.TXT_VC.Size = new System.Drawing.Size(209, 23);
            this.TXT_VC.TabIndex = 16;
            // 
            // LBL_VC
            // 
            this.LBL_VC.AutoSize = true;
            this.LBL_VC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_VC.Location = new System.Drawing.Point(247, 88);
            this.LBL_VC.Name = "LBL_VC";
            this.LBL_VC.Size = new System.Drawing.Size(161, 15);
            this.LBL_VC.TabIndex = 17;
            this.LBL_VC.Text = "Device Verification Code (VC)";
            // 
            // BTN_Batal
            // 
            this.BTN_Batal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Batal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Batal.Location = new System.Drawing.Point(284, 206);
            this.BTN_Batal.Name = "BTN_Batal";
            this.BTN_Batal.Size = new System.Drawing.Size(88, 30);
            this.BTN_Batal.TabIndex = 22;
            this.BTN_Batal.Text = "Batal";
            this.BTN_Batal.UseVisualStyleBackColor = true;
            this.BTN_Batal.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTambahAlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTambahAlat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TambahAlat";
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
        private System.Windows.Forms.Button BTN_Tambah;
        private System.Windows.Forms.Label LBL_VK;
        private System.Windows.Forms.TextBox TXT_DeviceName;
        private System.Windows.Forms.TextBox TXT_VK;
        private System.Windows.Forms.TextBox TXT_SN;
        private System.Windows.Forms.Label LBL_AC;
        private System.Windows.Forms.Label LBL_SN;
        private System.Windows.Forms.TextBox TXT_AC;
        private System.Windows.Forms.TextBox TXT_VC;
        private System.Windows.Forms.Label LBL_VC;
    }
}