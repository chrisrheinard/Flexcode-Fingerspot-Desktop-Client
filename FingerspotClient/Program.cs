using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
