using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models.Enums;

namespace Kuznia.Models
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public PackageStatus Status { get; set; } = PackageStatus.None;
    }
}
