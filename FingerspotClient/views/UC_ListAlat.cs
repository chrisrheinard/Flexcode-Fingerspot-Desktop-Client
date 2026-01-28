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

namespace FingerspotClient
{
    public partial class UC_ListAlat : UserControl
    {
        public UC_ListAlat()
        {
            InitializeComponent();
        }

        private void LoadDeviceData()
        {
            try
            {
                var repo = new DeviceRepository();
                List<Device> devices = repo.GetAll();

                // Kita matikan auto-generate columns jika ingin design manual di designer
                // dgvCustomers.AutoGenerateColumns = true; 

                DGV_DeviceList.DataSource = null; // Reset dulu
                DGV_DeviceList.DataSource = devices;

                // Rapikan Header
                if (DGV_DeviceList.Columns["Id"] != null) DGV_DeviceList.Columns["Id"].Visible = false; // Sembunyikan ID Internal
                DGV_DeviceList.Columns["Name"].HeaderText = "Nama Device";
                DGV_DeviceList.Columns["SerialNumber"].HeaderText = "Serial Number (SN)";
                DGV_DeviceList.Columns["VerificationCode"].HeaderText = "Verification Code";
                DGV_DeviceList.Columns["ActivationCode"].HeaderText = "Activation Code";
                DGV_DeviceList.Columns["ValidationKey"].HeaderText = "V-Key";
                DGV_DeviceList.Columns["CreatedAt"].HeaderText = "Tgl Registrasi";

                // Atur Lebar Kolom
                DGV_DeviceList.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Tambah_Click(object sender, EventArgs e)
        {
            // Buat instance dari form pop-up
            using (FormTambahAlat popUp = new FormTambahAlat())
            {
                // Tampilkan sebagai Dialog
                // ShowDialog() akan membekukan form utama sampai pop-up ditutup
                if (popUp.ShowDialog() == DialogResult.OK)
                {
                    // 3. Jika user klik Simpan, refresh tabel di List Nasabah
                    //RefreshTable();
                }
            }
        }

        private void UC_ListAlat_Load(object sender, EventArgs e)
        {
            LoadDeviceData();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadDeviceData();
        }
    }
}
