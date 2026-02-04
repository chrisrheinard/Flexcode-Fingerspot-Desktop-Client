using FlexCodeSDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FingerspotClient.services
{
    public static class DeviceService
    {
        private static FinFPReg FPReg;
        private static readonly FinFPVer FPVer;
        private static string _secretKey = "BPRCakhra2026"; // Harus sama saat Verifikasi!
        private static string _baseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fp_samples");

        public static void Init()
        {
            // Mesin SDK dihidupkan di sini
            FPReg = new FinFPReg();

            // Setup Ukuran sesuai panduan
            FPReg.PictureSampleHeight = 2050;
            FPReg.PictureSampleWidth = 1600;
            UpdatePath();
        }

        public static void StartRegister()
        {
            if (!Directory.Exists(_baseFolder)) Directory.CreateDirectory(_baseFolder);

            // Set path awal sebelum mulai
            UpdatePath();
            FPReg.FPRegistrationStart(_secretKey);
        }

        private static void UpdatePath()
        {
            // Nama file: 20260204_0855.bmp
            string fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bmp";
            FPReg.PictureSamplePath = Path.Combine(_baseFolder, fileName);
        }

        public static void InitializeDevice(string sn, string vc, string ac)
        {
            try
            {
                if (FPReg.DeviceInfo(sn, vc, ac))
                {
                    MessageBox.Show("Berhasil menghubungkan device");
                } 
                else
                {
                    MessageBox.Show("Gagal menghubungkan device");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghubungkan device. Error: " + ex.Message);
            }
        }
    }
}
