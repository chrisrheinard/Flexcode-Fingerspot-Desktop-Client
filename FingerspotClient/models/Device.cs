using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string SerialNumber { get; set; } 
        public string VerificationCode { get; set; }
        public string ActivationCode { get; set; }
        public string ValidationKey { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
