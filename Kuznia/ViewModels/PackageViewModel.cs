using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuznia.ViewModels
{
    public class PackageViewModel
    {
        public int PackageId { get; set; }
        public string Status { get; set; }
        public DateTime DeliveryDateTime { get; set; }
    }
}
