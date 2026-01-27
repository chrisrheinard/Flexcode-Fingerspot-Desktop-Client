using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.models
{
    internal class VerificationLog
    {
        public int Id { get; set; }
        public string NasabahId { get; set; }
        public DateTime Waktu { get; set; }
        public byte[] EvidenceImage { get; set; }
        public string DeviceId { get; set; }
    }
}
