using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.models
{
    internal class Nasabah
    {
        public string Id { get; set; }
        public string Nama { get; set; }
        public string FingerTemplate { get; set; }
        public List<byte[]> FingerImages { get; set; } = new List<byte[]>();

        // Informasi Tambahan
        public DateTime TanggalRegistrasi { get; set; }
        public string AdminRegistrasi { get; set; }
    }
}
