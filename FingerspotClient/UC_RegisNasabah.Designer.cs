namespace FingerspotClient
{
    partial class UC_RegisNasabah
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
            this.LBL_NamaNasabah = new System.Windows.Forms.Label();
            this.TXT_NamaNasabah = new System.Windows.Forms.TextBox();
            this.BTN_TambahNasabah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_NamaNasabah
            // 
            this.LBL_NamaNasabah.AutoSize = true;
            this.LBL_NamaNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LBL_NamaNasabah.Location = new System.Drawing.Point(91, 55);
            this.LBL_NamaNasabah.Name = "LBL_NamaNasabah";
            this.LBL_NamaNasabah.Size = new System.Drawing.Size(94, 15);
            this.LBL_NamaNasabah.TabIndex = 0;
            this.LBL_NamaNasabah.Text = "Nama Nasabah";
            // 
            // TXT_NamaNasabah
            // 
            this.TXT_NamaNasabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TXT_NamaNasabah.Location = new System.Drawing.Point(94, 73);
            this.TXT_NamaNasabah.Name = "TXT_NamaNasabah";
            this.TXT_NamaNasabah.Size = new System.Drawing.Size(184, 21);
            this.TXT_NamaNasabah.TabIndex = 1;
            // 
            // BTN_TambahNasabah
            // 
            this.BTN_TambahNasabah.Location = new System.Drawing.Point(203, 100);
            this.BTN_TambahNasabah.Name = "BTN_TambahNasabah";
            this.BTN_TambahNasabah.Size = new System.Drawing.Size(75, 23);
            this.BTN_TambahNasabah.TabIndex = 2;
            this.BTN_TambahNasabah.Text = "Tambah";
            this.BTN_TambahNasabah.UseVisualStyleBackColor = true;
            // 
            // UC_RegisNasabah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.BTN_TambahNasabah);
            this.Controls.Add(this.TXT_NamaNasabah);
            this.Controls.Add(this.LBL_NamaNasabah);
            this.Name = "UC_RegisNasabah";
            this.Size = new System.Drawing.Size(354, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_NamaNasabah;
        private System.Windows.Forms.TextBox TXT_NamaNasabah;
        private System.Windows.Forms.Button BTN_TambahNasabah;
    }
}
