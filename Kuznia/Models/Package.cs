using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models.Enums;

namespace Kuznia.Models
{
    public class Package
    {
        public int PackageId { get; set; }
        public PackageStatus Status { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
