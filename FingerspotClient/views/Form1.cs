using FingerspotClient.services;
using MySql.Data.MySqlClient;
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
    public partial class FingerspotClient : Form
    {
        public FingerspotClient()
        {
            InitializeComponent();

            // Mencegah Form menutupi Taskbar saat WindowState = Maximized
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Mengaktifkan DoubleBuffering pada Panel via Reflection
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, PanelMain, new object[] { true });

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
            // Munculkan jendela konfirmasi (Modal)
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Jika user klik 'Yes', maka tutup aplikasinya
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void showControl(UserControl userControl)
        {
            // Bersihkan panel agar halaman sebelumnya hilang
            PanelMain.Controls.Clear();

            // Atur agar User Control memenuhi seluruh area panel
            userControl.Dock = DockStyle.Fill;

            // Masukkan User Control ke dalam Panel
            PanelMain.Controls.Add(userControl);

            // Bawa ke depan agar tidak tertutup elemen lain
            userControl.BringToFront();
        }

        private void HighlightButton(Button activeBtn)
        {
            // List semua tombol menu kamu
            Button[] menuButtons = { BTN_RegisNasabah, BTN_ListNasabah, BTN_VerifNasabah, BTN_LogNasabah, BTN_ListAlat };

            foreach (var btn in menuButtons)
            {
                if (btn == activeBtn)
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219); // Biru Terang (Aktif)
                    btn.ForeColor = Color.FromArgb(236, 240, 241);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(44, 62, 80); // Atau warna sidebar asal
                    btn.ForeColor = Color.FromArgb(236, 240, 241);
                }
            }
        }

        UC_RegisNasabah ucRegisNasabah;
        UC_ListNasabah ucListNasabah;
        UC_VerifNasabah ucVerifNasabah;
        UC_LogNasabah ucLogNasabah;
        UC_ListAlat ucListAlat;

        private void BTN_RegisNasabah_Click(object sender, EventArgs e)
        {
            if (ucRegisNasabah == null)
            {
                ucRegisNasabah = new UC_RegisNasabah();
            }
            showControl(ucRegisNasabah);
            HighlightButton(BTN_RegisNasabah);
        }

        private void BTN_ListNasabah_Click(object sender, EventArgs e)
        {
            if (ucListNasabah == null)
            {
                ucListNasabah = new UC_ListNasabah();
            }
            showControl(ucListNasabah);
            HighlightButton(BTN_ListNasabah);
        }

        private void BTN_VerifNasabah_Click(object sender, EventArgs e)
        {
            if (ucVerifNasabah == null)
            {
                ucVerifNasabah = new UC_VerifNasabah();
            }
            showControl(ucVerifNasabah);
            HighlightButton(BTN_VerifNasabah);
        }

        private void BTN_LogNasabah_Click(object sender, EventArgs e)
        {
            if (ucLogNasabah == null)
            {
                ucLogNasabah = new UC_LogNasabah();
            }
            showControl(ucLogNasabah);
            HighlightButton(BTN_LogNasabah);
        }

        private void BTN_ListAlat_Click(object sender, EventArgs e)
        {
            if (ucListAlat == null)
            {
                ucListAlat = new UC_ListAlat();
            }
            showControl(ucListAlat);
            HighlightButton(BTN_ListAlat);
        }

        private void FingerspotClient_Load(object sender, EventArgs e)
        {
            BTN_RegisNasabah.PerformClick();

            // Mengambil versi dari Assembly (biasanya formatnya 1.0.0.0)
            string version = Application.ProductVersion;

            DateTime buildDate = System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Tampilkan ke label
            LBL_Version.Text = $"v{version} ({buildDate:dd MMM yyyy})";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timerKoneksi_Tick(object sender, EventArgs e)
        {
            // Jalankan pengecekan di background agar UI tidak patah-patah
            Task.Run(() => {
                var dbService = new DatabaseService();
                bool isAlive = dbService.IsServerReachable();
                string ipServer = dbService.GetServerIp();

                // Update UI harus lewat Invoke
                this.Invoke(new MethodInvoker(delegate {
                    if (isAlive)
                    {
                        LBL_StatusServer.Text = $"Server: {ipServer} (Connected)";
                        LBL_StatusServer.ForeColor = Color.Green;
                    }
                    else
                    {
                        LBL_StatusServer.Text = $"Server: {ipServer} (Disconnected)";
                        LBL_StatusServer.ForeColor = Color.Red;
                        // Opsional: munculkan notifikasi peringatan
                    }
                }));
            });
        }

        private void BTN_Keluar_Click(object sender, EventArgs e)
        {
            // Munculkan jendela konfirmasi (Modal)
            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin keluar dari aplikasi?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Jika user klik 'Yes', maka tutup aplikasinya
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
