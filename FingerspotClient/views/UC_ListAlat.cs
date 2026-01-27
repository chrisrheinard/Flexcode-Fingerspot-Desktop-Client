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
    }
}
