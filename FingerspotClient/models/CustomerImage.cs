using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.models
{
    public class CustomerImage
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public byte[] ImageData { get; set; }
        public int ScanOrder { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
