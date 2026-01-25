using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerspotClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        // Memungkinkan drag form tanpa border
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            // Memanggil fungsi Windows untuk memulai drag window
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void CB_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ShowPassword.Checked)
            {
                TXT_Password.UseSystemPasswordChar = false;
            }
            else
            {
                TXT_Password.UseSystemPasswordChar = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Mengambil versi dari Assembly (biasanya formatnya 1.0.0.0)
            string version = Application.ProductVersion;

            DateTime buildDate = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Tampilkan ke label
            LBL_Version.Text = $"v{version} ({buildDate:dd MMM yyyy})";
        }
    }
}
