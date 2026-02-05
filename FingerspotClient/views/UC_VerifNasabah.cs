using FingerspotClient.helpers;
using FingerspotClient.models;
using FingerspotClient.respositories;
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
        FlexCodeSDK.FinFPVer FPVer;
        private string _baseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fp_samples");
        string CurrentId = "";
        string fileName = "";
        private readonly DatabaseService _dbService;
        private readonly LogRepository _logRepo;
        int customerId;
        string template = "";
        byte[] _fingerImage = null;

        public UC_VerifNasabah()
        {
            InitializeComponent();
            _logRepo = new LogRepository();
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
            LBL_Status.Visible = false;

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
        }

        public void FPVer_FPVerificationStatus(VerificationStatus Status)
        {
            if (Status == VerificationStatus.v_OK)
            {
                LBL_Status.Visible = true;
                LBL_Status.Text = "Verified!";
                CreateNewRecord(CurrentId, _fingerImage);

            }
            else if (Status == VerificationStatus.v_NotMatch)
            {
                LBL_Status.Visible = true;
                LBL_Status.Text = "Not Recognized";
            }
        }

        public void FPVer_FPVerificationImage()
        {
            pictureBox1.Load(Path.Combine(_baseFolder, fileName));
            if (File.Exists(Path.Combine(_baseFolder, fileName)))
            {
                byte[] imageData = File.ReadAllBytes(Path.Combine(_baseFolder, fileName));
                _fingerImage = imageData;
            }
        }

        public void FPVer_FPVerificationID(string ID, FingerNumber FingerNr)
        {
            CurrentId = ID;
        }

        private void UpdatePath()
        {
            // Nama file: FP_20260204_0855.bmp
            fileName = "FP_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bmp";
            FPVer.PictureSamplePath = Path.Combine(_baseFolder, fileName);
        }

        private void BTN_Verifikasi_Click(object sender, EventArgs e)
        {
            

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
                            customerId = rdr.GetInt32(0);
                            template = rdr.GetString(4);

                            // Load ke FlexCode SDK
                            // Parameter 4 (Secret Key) harus sama dengan pas Register dulu!
                            FPVer.FPLoad(customerId.ToString(), 0, template, "BPRCakhra2026");
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
            FPVer.FPVerificationStop();
        }

        private void CreateNewRecord(string custId, byte[] evidenceImage)
        {
            try
            {
                var newLog = new VerificationLog
                {
                    CustomerId = Convert.ToInt32(custId),
                    TellerId = UserSession.UserId,
                    DeviceId = Properties.Settings.Default.LastDeviceId,
                    PcName = SystemInformation.ComputerName,
                    EvidenceImage = evidenceImage
                };

                // Kirim ke Repo
                bool isSuccess = _logRepo.Create(newLog);

                if (isSuccess)
                {
                    MessageBox.Show("Verifikasi berhasil! Log telah tersimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
