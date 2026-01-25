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
        }
    }
}
