using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.models
{
    public class VerificationLog
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string TellerName { get; set; }
        public string DeviceName { get; set; }
        public string PcName { get; set; }
        public DateTime VerifiedAt { get; set; }
        public byte[] EvidenceImage { get; set; }
    }
}
