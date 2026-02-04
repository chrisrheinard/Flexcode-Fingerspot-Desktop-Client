using FingerspotClient.models;
using FingerspotClient.respositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FingerspotClient
{
    public partial class FormTambahAlat : Form
    {
        private readonly DeviceRepository _deviceRepo;
        public FormTambahAlat()
        {
            InitializeComponent();
            _deviceRepo = new DeviceRepository(); // Inisialisasi repo
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTN_Tambah_Click(object sender, EventArgs e)
        {
            try
            {
                var newDevice = new Device
                {
                    Name = TXT_DeviceName.Text.Trim(),
                    SerialNumber = TXT_SN.Text.Trim(),
                    VerificationCode = TXT_VC.Text.Trim(),
                    ActivationCode = TXT_AC.Text.Trim(),
                    ValidationKey = TXT_VK.Text.Trim()
                };

                // Kirim ke Repo
                bool isSuccess = _deviceRepo.Create(newDevice);

                if (isSuccess)
                {
                    MessageBox.Show("Alat berhasil didaftarkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // Memberitahu form utama untuk refresh grid
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
