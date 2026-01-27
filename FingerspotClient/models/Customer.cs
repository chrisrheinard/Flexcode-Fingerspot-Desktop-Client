using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FingerspotClient.models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string CbsId { get; set; } // Core Banking System ID
        public string Name { get; set; }
        public string FingerTemplate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
