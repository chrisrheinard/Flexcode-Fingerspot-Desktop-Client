using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerspotClient.views
{
    public partial class FormPreviewBukti : Form
    {
        public FormPreviewBukti(byte[] imageBytes, string title)
        {
            InitializeComponent();
            this.Text = "Bukti: " + title; // Judul biar informatif

            if (imageBytes != null)
            {
                using (var ms = new MemoryStream(imageBytes))
                {
                    PB_Bukti.Image = Image.FromStream(ms);
                }
            }
        }

        private void FormPreviewBukti_Load(object sender, EventArgs e)
        {

        }
    }
}
