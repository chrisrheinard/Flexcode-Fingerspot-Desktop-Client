using FlexCodeSDK;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using FingerspotClient.models;
using FingerspotClient.respositories;

namespace FingerspotClient
{
    public partial class UC_RegisNasabah : UserControl
    {
        FinFPReg FPReg;
        string template = "";
        private string _secretKey = "BPRCakhra2026"; // Harus sama saat Verifikasi!
        private string _baseFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fp_samples");
        string fileName = "";

        public UC_RegisNasabah()
        {
            InitializeComponent();
        }

        private void BTN_TambahNasabah_Click(object sender, EventArgs e)
        {
            if (TXT_IdNasabah.Text == "" || TXT_NamaNasabah.Text == "")
            {
                MessageBox.Show("Please enter ID and Name!");
            }
            else
            {
                TXT_IdNasabah.Enabled = false;
                TXT_NamaNasabah.Enabled = false;
                BTN_TambahNasabah.Enabled = false;
                BTN_Cancel.Enabled = true;
                FPReg.FPRegistrationStart(_secretKey);
            }
        }

        private void UC_RegisNasabah_Load(object sender, EventArgs e)
        {
            //Initialize FlexCodeSDK for Registration
            //1. Initialize Event Handler
            FPReg = new FlexCodeSDK.FinFPReg();
            FPReg.FPSamplesNeeded += new __FinFPReg_FPSamplesNeededEventHandler(FPReg_FPSamplesNeeded);
            FPReg.FPRegistrationTemplate += new __FinFPReg_FPRegistrationTemplateEventHandler(FPReg_FPRegistrationTemplate);
            FPReg.FPRegistrationImage += new __FinFPReg_FPRegistrationImageEventHandler(FPReg_FPRegistrationImage);
            FPReg.FPRegistrationStatus += new __FinFPReg_FPRegistrationStatusEventHandler(FPReg_FPRegistrationStatus);

            //2. Input the activation code
            FPReg.AddDeviceInfo(
                Properties.Settings.Default.LastDeviceSN, 
                Properties.Settings.Default.LastDeviceVC, 
                Properties.Settings.Default.LastDeviceAC
                );

            //3. Define fingerprint image
            FPReg.PictureSampleHeight = (short)(pictureBox1.Height * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            FPReg.PictureSampleWidth = (short)(pictureBox1.Width * 15); //FlexCodeSDK use Twips. 1 pixel = 15 twips
            UpdatePath();

        }
        public void FPReg_FPRegistrationStatus(RegistrationStatus Status)
        {
            if (Status == RegistrationStatus.r_OK)
            {
                MessageBox.Show("Success!");
                TXT_IdNasabah.Text = "";
                TXT_NamaNasabah.Text = "";
                TXT_IdNasabah.Enabled = true;
                TXT_NamaNasabah.Enabled = true;
                BTN_TambahNasabah.Enabled = true;
                BTN_Cancel.Enabled = false;
                template = "";
            }

        }
        public void FPReg_FPRegistrationTemplate(String FPTemplate)
        {
            template = FPTemplate;
        }
        public void FPReg_FPRegistrationImage()
        {
            pictureBox1.Load(Path.Combine(_baseFolder, fileName));
        }
        public void FPReg_FPSamplesNeeded(short Samples)
        {
            LBL_Sample.Text = "Samples Needed: " + Convert.ToString(Samples);
        }

        private void UpdatePath()
        {
            // Nama file: 20260204_0855.bmp
            fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bmp";
            FPReg.PictureSamplePath = Path.Combine(_baseFolder, fileName);
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Canceled!");
            LBL_Sample.Text = "Samples Needed: 0";
            TXT_IdNasabah.Enabled = true;
            TXT_NamaNasabah.Enabled = true;
            BTN_TambahNasabah.Enabled = true;
            BTN_Cancel.Enabled = false;
        }
    }
}
