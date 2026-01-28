namespace FingerspotClient.views
{
    partial class FormPreviewBukti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreviewBukti));
            this.PB_Bukti = new System.Windows.Forms.PictureBox();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Bukti)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Bukti
            // 
            this.PB_Bukti.Dock = System.Windows.Forms.DockStyle.Top;
            this.PB_Bukti.Location = new System.Drawing.Point(0, 0);
            this.PB_Bukti.Name = "PB_Bukti";
            this.PB_Bukti.Size = new System.Drawing.Size(282, 282);
            this.PB_Bukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Bukti.TabIndex = 0;
            this.PB_Bukti.TabStop = false;
            // 
            // BTN_Print
            // 
            this.BTN_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Print.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Print.Location = new System.Drawing.Point(4, 7);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(131, 37);
            this.BTN_Print.TabIndex = 12;
            this.BTN_Print.Text = "Cetak";
            this.BTN_Print.UseVisualStyleBackColor = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save.Location = new System.Drawing.Point(143, 7);
            this.BTN_Save.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(131, 37);
            this.BTN_Save.TabIndex = 13;
            this.BTN_Save.Text = "Simpan";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_Close);
            this.panel1.Controls.Add(this.BTN_Print);
            this.panel1.Controls.Add(this.BTN_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 95);
            this.panel1.TabIndex = 14;
            // 
            // BTN_Close
            // 
            this.BTN_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.Location = new System.Drawing.Point(4, 52);
            this.BTN_Close.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(270, 37);
            this.BTN_Close.TabIndex = 14;
            this.BTN_Close.Text = "Tutup";
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // FormPreviewBukti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB_Bukti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreviewBukti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPreviewBukti";
            this.Load += new System.EventHandler(this.FormPreviewBukti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Bukti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Bukti;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Close;
    }
}