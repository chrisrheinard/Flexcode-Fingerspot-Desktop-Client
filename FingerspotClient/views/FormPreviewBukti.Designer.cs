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
            ((System.ComponentModel.ISupportInitialize)(this.PB_Bukti)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Bukti
            // 
            this.PB_Bukti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Bukti.Location = new System.Drawing.Point(0, 0);
            this.PB_Bukti.Name = "PB_Bukti";
            this.PB_Bukti.Size = new System.Drawing.Size(282, 253);
            this.PB_Bukti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Bukti.TabIndex = 0;
            this.PB_Bukti.TabStop = false;
            // 
            // FormPreviewBukti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.PB_Bukti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPreviewBukti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPreviewBukti";
            this.Load += new System.EventHandler(this.FormPreviewBukti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Bukti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Bukti;
    }
}