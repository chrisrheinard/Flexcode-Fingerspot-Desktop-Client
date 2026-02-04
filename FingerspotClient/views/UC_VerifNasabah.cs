using FingerspotClient.services;
using FlexCodeSDK;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FingerspotClient
{
    public partial class UC_VerifNasabah : UserControl
    {
        private readonly DatabaseService _dbService;
        FlexCodeSDK.FinFPVer FPVer;
        FlexCodeSDK.FinFPImg FPImg;
        private string _baseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fp_samples");
        string CurrentId = "";
        string fileName = "";

        public UC_VerifNasabah()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_VerifNasabah_Load(object sender, EventArgs e)
        {
            
        }

        public void FPVer_FPVerificationStatus(VerificationStatus Status)
        {
            if (Status == VerificationStatus.v_OK)
            {
                LBL_Status.Text = "Verified!";
            }
            else if (Status == VerificationStatus.v_NotMatch)
            {
                LBL_Status.Text = "Not Recognized";
            }
        }
        public void FPVer_FPVerificationImage()
        {
            pictureBox1.Load(Path.Combine(_baseFolder, fileName));
        }
        public void FPVer_FPVerificationID(string ID, FingerNumber FingerNr)
        {
            CurrentId = ID;
        }
        private void UpdatePath()
        {
            // Nama file: 20260204_0855.bmp
            fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bmp";
            FPVer.PictureSamplePath = Path.Combine(_baseFolder, fileName);
        }

        private void BTN_Verifikasi_Click(object sender, EventArgs e)
        {
            FPVer = new FlexCodeSDK.FinFPVer();
            FPVer.FPVerificationID += new __FinFPVer_FPVerificationIDEventHandler(FPVer_FPVerificationID);
            FPVer.FPVerificationImage += new __FinFPVer_FPVerificationImageEventHandler(FPVer_FPVerificationImage);
            FPVer.FPVerificationStatus += new __FinFPVer_FPVerificationStatusEventHandler(FPVer_FPVerificationStatus);

            // Input the activation code
            FPVer.AddDeviceInfo(
                Properties.Settings.Default.LastDeviceSN,
                Properties.Settings.Default.LastDeviceVC,
                Properties.Settings.Default.LastDeviceAC
                );

            // Define fingerprint image
            FPVer.PictureSampleHeight = (short)(pictureBox1.Height * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            FPVer.PictureSampleWidth = (short)(pictureBox1.Width * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            UpdatePath();

            // ---

            BTN_Cancel.Enabled = true;
            BTN_Verifikasi.Enabled = false;
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                string sql = "SELECT id, finger_template FROM customers";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            string customerId = rdr.GetString(0);
                            string template = rdr.GetString(4);

                            // Load ke FlexCode SDK
                            // Parameter 4 (Secret Key) harus sama dengan pas Register dulu!
                            FPVer.FPLoad(customerId, 0, template, "BPRCakhra2026");
                        }
                    }
                }

            }
            FPVer.FPVerificationStart();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            BTN_Cancel.Enabled = false;
            BTN_Verifikasi.Enabled = true;
        }
    }
}
