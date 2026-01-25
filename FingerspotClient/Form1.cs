using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FingerspotClient
{
    public partial class FingerspotClient : Form
    {
        public FingerspotClient()
        {
            InitializeComponent();

            // Mencegah Form menutupi Taskbar saat WindowState = Maximized
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Jika sedang ukuran normal, maka diperbesar
                this.WindowState = FormWindowState.Maximized;
                ButtonMax.Text = "❐";
            }
            else
            {
                // Jika sedang diperbesar, maka dikembalikan ke ukuran normal
                this.WindowState = FormWindowState.Normal;
                ButtonMax.Text = "▢";
            }
        }
    }
}
