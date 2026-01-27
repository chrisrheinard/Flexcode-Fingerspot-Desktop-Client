namespace FingerspotClient
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Username = new System.Windows.Forms.TextBox();
            this.TXT_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_ShowPassword = new System.Windows.Forms.CheckBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.PanelSidebarFooter = new System.Windows.Forms.Panel();
            this.LBL_Copyright = new System.Windows.Forms.Label();
            this.LBL_Version = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelSidebarFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PanelHeader.Controls.Add(this.LBL_Title);
            this.PanelHeader.Controls.Add(this.ButtonExit);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(361, 39);
            this.PanelHeader.TabIndex = 3;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // LBL_Title
            // 
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBL_Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.LBL_Title.Location = new System.Drawing.Point(0, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LBL_Title.Size = new System.Drawing.Size(245, 39);
            this.LBL_Title.TabIndex = 4;
            this.LBL_Title.Text = "Login";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBL_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ButtonExit.Location = new System.Drawing.Point(315, 0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(46, 39);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "🗙";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(93, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fingerspot Client";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FingerspotClient.Properties.Resources.icon_64x64;
            this.pictureBox1.Location = new System.Drawing.Point(148, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(145, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXT_Username
            // 
            this.TXT_Username.BackColor = System.Drawing.Color.White;
            this.TXT_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Username.Location = new System.Drawing.Point(78, 209);
            this.TXT_Username.Name = "TXT_Username";
            this.TXT_Username.Size = new System.Drawing.Size(205, 22);
            this.TXT_Username.TabIndex = 8;
            this.TXT_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_Password
            // 
            this.TXT_Password.BackColor = System.Drawing.Color.White;
            this.TXT_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Password.Location = new System.Drawing.Point(78, 280);
            this.TXT_Password.Name = "TXT_Password";
            this.TXT_Password.Size = new System.Drawing.Size(205, 22);
            this.TXT_Password.TabIndex = 10;
            this.TXT_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_Password.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label4.Location = new System.Drawing.Point(145, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CB_ShowPassword
            // 
            this.CB_ShowPassword.AutoSize = true;
            this.CB_ShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.CB_ShowPassword.Location = new System.Drawing.Point(126, 304);
            this.CB_ShowPassword.Name = "CB_ShowPassword";
            this.CB_ShowPassword.Size = new System.Drawing.Size(108, 19);
            this.CB_ShowPassword.TabIndex = 11;
            this.CB_ShowPassword.Text = "Show Password";
            this.CB_ShowPassword.UseVisualStyleBackColor = true;
            this.CB_ShowPassword.CheckedChanged += new System.EventHandler(this.CB_ShowPassword_CheckedChanged);
            // 
            // BTN_Login
            // 
            this.BTN_Login.BackColor = System.Drawing.Color.White;
            this.BTN_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Login.Location = new System.Drawing.Point(103, 352);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(154, 30);
            this.BTN_Login.TabIndex = 12;
            this.BTN_Login.Text = "Masuk";
            this.BTN_Login.UseVisualStyleBackColor = false;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // PanelSidebarFooter
            // 
            this.PanelSidebarFooter.Controls.Add(this.LBL_Copyright);
            this.PanelSidebarFooter.Controls.Add(this.LBL_Version);
            this.PanelSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelSidebarFooter.Location = new System.Drawing.Point(0, 414);
            this.PanelSidebarFooter.Name = "PanelSidebarFooter";
            this.PanelSidebarFooter.Size = new System.Drawing.Size(361, 64);
            this.PanelSidebarFooter.TabIndex = 13;
            // 
            // LBL_Copyright
            // 
            this.LBL_Copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_Copyright.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Copyright.ForeColor = System.Drawing.Color.Silver;
            this.LBL_Copyright.Location = new System.Drawing.Point(0, 28);
            this.LBL_Copyright.Name = "LBL_Copyright";
            this.LBL_Copyright.Size = new System.Drawing.Size(361, 36);
            this.LBL_Copyright.TabIndex = 7;
            this.LBL_Copyright.Text = "© 2026 Christian Rheinard Sadeko\r\nAll rights reserved.";
            this.LBL_Copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LBL_Version
            // 
            this.LBL_Version.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Version.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Version.ForeColor = System.Drawing.Color.Silver;
            this.LBL_Version.Location = new System.Drawing.Point(0, 0);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(361, 28);
            this.LBL_Version.TabIndex = 6;
            this.LBL_Version.Text = "v1.0.0 (25 Jan 2026)";
            this.LBL_Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(361, 478);
            this.Controls.Add(this.PanelSidebarFooter);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.CB_ShowPassword);
            this.Controls.Add(this.TXT_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PanelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelSidebarFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Username;
        private System.Windows.Forms.TextBox TXT_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CB_ShowPassword;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Panel PanelSidebarFooter;
        private System.Windows.Forms.Label LBL_Copyright;
        private System.Windows.Forms.Label LBL_Version;
    }
}