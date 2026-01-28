using FingerspotClient.models;
using FingerspotClient.respositories;
using FingerspotClient.views;
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
    public partial class UC_ListNasabah : UserControl
    {
        public UC_ListNasabah()
        {
            InitializeComponent();
        }

        private void TXT_Search_TextChanged(object sender, EventArgs e)
        {
            // Setiap user mengetik satu huruf, tabel langsung terfilter
            //DataView dv = dtNasabah.DefaultView;
            //dv.RowFilter = string.Format("nama_nasabah LIKE '%{0}%'", TXT_Search.Text);
            var repo = new CustomerRepository();
            DGV_ListCustomer.DataSource = repo.Search(TXT_Search.Text);
        }

        private void LoadCustomerData()
        {
            try
            {
                var repo = new CustomerRepository();
                List<Customer> customers = repo.GetAll();

                // Kita matikan auto-generate columns jika ingin design manual di designer
                // dgvCustomers.AutoGenerateColumns = true; 

                DGV_ListCustomer.DataSource = null; // Reset dulu
                DGV_ListCustomer.DataSource = customers;

                // Rapikan Header
                if (DGV_ListCustomer.Columns["Id"] != null) DGV_ListCustomer.Columns["Id"].Visible = false; // Sembunyikan ID Internal
                DGV_ListCustomer.Columns["CbsId"].HeaderText = "No. Rekening / CBS ID";
                DGV_ListCustomer.Columns["Name"].HeaderText = "Nama Nasabah";
                DGV_ListCustomer.Columns["CreatedAt"].HeaderText = "Tgl Registrasi";

                // Atur Lebar Kolom
                DGV_ListCustomer.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message);
            }
        }

        private void BTN_UbahData_Click(object sender, EventArgs e)
        {
            if (DGV_ListCustomer.SelectedRows.Count > 0)
            {
                // 1. Ambil data dari baris yang dipilih
                var selectedRow = DGV_ListCustomer.SelectedRows[0];

                Customer selectedCustomer = new Customer
                {
                    Id = (int)selectedRow.Cells["Id"].Value,
                    CbsId = selectedRow.Cells["CbsId"].Value?.ToString(),
                    Name = selectedRow.Cells["Name"].Value?.ToString(),
                    FingerTemplate = selectedRow.Cells["FingerTemplate"].Value?.ToString()
                };

                // 2. Buka Form Update dan kirim datanya lewat Constructor
                UbahNasabah frmUpdate = new UbahNasabah(selectedCustomer);

                if (frmUpdate.ShowDialog() == DialogResult.OK)
                {
                    // 3. Refresh Grid setelah form ditutup
                    LoadCustomerData();
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih nasabah terlebih dahulu!");
            }
        }

        private void UC_ListNasabah_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void BTN_Refresh_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void BTN_HapusData_Click(object sender, EventArgs e)
        {
            if (DGV_ListCustomer.SelectedRows.Count > 0)
            {
                var id = (int)DGV_ListCustomer.SelectedRows[0].Cells["Id"].Value;
                var name = DGV_ListCustomer.SelectedRows[0].Cells["Name"].Value.ToString();

                var confirm = MessageBox.Show($"Hapus nasabah {name}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var repo = new CustomerRepository();
                    if (repo.Delete(id))
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        LoadCustomerData(); // Refresh Grid
                    }
                }
            }
        }
    }
}
