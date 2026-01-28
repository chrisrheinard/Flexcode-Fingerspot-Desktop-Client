using FingerspotClient.respositories;
using FingerspotClient.views;
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

namespace FingerspotClient
{
    public partial class UC_LogNasabah : UserControl
    {
        public UC_LogNasabah()
        {
            InitializeComponent();
        }

        private void LoadLogData()
        {
            try
            {
                var repo = new LogRepository();

                // Ambil nilai dari input UI
                string keyword = TXT_Search.Text.Trim();
                DateTime start = DTP_Start.Value;
                DateTime end = DTP_End.Value;

                // Ganti repo.GetAll() dengan repo.Search()
                // Jika keyword kosong, Search otomatis akan ambil semua data di range tanggal tersebut
                DGV_ListLog.DataSource = null;
                DGV_ListLog.DataSource = repo.Search(keyword, start, end);

                // --- Bagian Atur Tampilan (Tetap Sama Seperti Punya Kamu) ---
                DGV_ListLog.Columns["Id"].Visible = false;
                DGV_ListLog.Columns["EvidenceImage"].Visible = false;

                DGV_ListLog.Columns["CustomerName"].HeaderText = "Nasabah";
                DGV_ListLog.Columns["TellerName"].HeaderText = "Petugas/Teller";
                DGV_ListLog.Columns["DeviceName"].HeaderText = "Alat";
                DGV_ListLog.Columns["PcName"].HeaderText = "Nama PC";
                DGV_ListLog.Columns["VerifiedAt"].HeaderText = "Waktu Verifikasi";
                DGV_ListLog.Columns["VerifiedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

                DGV_ListLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void UC_LogNasabah_Load(object sender, EventArgs e)
        {
            // dtpStart diatur ke jam 00:00:00 hari ini
            //DTP_Start.Value = DateTime.Now.Date;

            // Start diatur ke 7 hari yang lalu jam 00:00
            DTP_Start.Value = DateTime.Now.Date.AddDays(-7);

            // dtpEnd diatur ke jam 23:59:59 hari ini
            DTP_End.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1);

            LoadLogData();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadLogData();
        }

        private void BTN_Lihat_Click(object sender, EventArgs e)
        {
            if (DGV_ListLog.SelectedRows.Count > 0)
            {
                int logId = (int)DGV_ListLog.SelectedRows[0].Cells["Id"].Value;
                string namaNasabah = DGV_ListLog.SelectedRows[0].Cells["CustomerName"].Value.ToString();

                var repo = new LogRepository();
                byte[] imgBytes = repo.GetEvidenceImage(logId);

                if (imgBytes != null)
                {
                    // Panggil si jendela kecil tadi
                    FormPreviewBukti frm = new FormPreviewBukti(imgBytes, namaNasabah);
                    frm.ShowDialog(); // ShowDialog supaya user fokus ke gambar dulu
                }
                else
                {
                    MessageBox.Show("Gambar tidak tersedia.");
                }
            }
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {
            // Hanya cari kalau sudah ngetik lebih dari 2 karakter
            if (TXT_Search.Text.Length > 1 || TXT_Search.Text.Length == 0)
            {
                LoadLogData();
            }
        }

        private void BTN_Cari_Click(object sender, EventArgs e)
        {
            LoadLogData();
        }
    }
}
