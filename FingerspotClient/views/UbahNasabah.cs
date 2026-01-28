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

namespace FingerspotClient.views
{
    public partial class UbahNasabah : Form
    {
        private Customer _currentCustomer;
        public UbahNasabah(Customer customer)
        {
            InitializeComponent();
            _currentCustomer = customer; // Simpan data di variabel level class

            // Tampilkan data ke TextBox saat form dibuka
            TXT_ID.Text = _currentCustomer.CbsId;
            TXT_Nama.Text = _currentCustomer.Name;

            // ID ditampilkan tapi diproteksi
            //TXT_ID.Text = _currentCustomer.Id.ToString();
            //TXT_ID.ReadOnly = true;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTN_Batal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTN_Ubah_Click(object sender, EventArgs e)
        {
            // Ambil nilai baru dari TextBox
            _currentCustomer.CbsId = TXT_ID.Text;
            _currentCustomer.Name = TXT_Nama.Text;

            var repo = new CustomerRepository();
            if (repo.Update(_currentCustomer))
            {
                MessageBox.Show("Data Nasabah Berhasil Diperbarui!");
                this.DialogResult = DialogResult.OK; // Menutup form dan memberi sinyal sukses
                this.Close();
            }
        }
    }
}
