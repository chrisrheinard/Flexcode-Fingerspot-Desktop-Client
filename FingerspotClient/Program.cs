using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FingerspotClient.services;

namespace FingerspotClient
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbService = new DatabaseService();
            if (!dbService.IsServerReachable())
            {
                MessageBox.Show("PC ini tidak terhubung ke Jaringan/Server. Cek Kabel LAN!",
                                "Offline", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Jalankan inisialisasi database
                dbService.InitializeDatabase();

                // Jika database OK, lanjut ke Login
                // Buat instance Form Login
                FormLogin frmLogin = new FormLogin();

                // Tampilkan Form Login sebagai Dialog (Aplikasi berhenti di sini sampai Login ditutup)
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    // Jika Login Berhasil (mengirim sinyal OK), jalankan Form Utama
                    Application.Run(new FingerspotClient());
                }
                else
                {
                    // Jika User klik Batal/Exit di Login, aplikasi benar-benar mati
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database server: " + ex.Message,
                        "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
