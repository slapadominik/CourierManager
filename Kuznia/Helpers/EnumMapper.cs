using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models.Enums;

namespace Kuznia.Helpers
{
    public static class EnumMapper
    {
        public static Dictionary<PackageStatus, string> PackageStatuses = new Dictionary<PackageStatus, string>()
        {
            {PackageStatus.None, "Brak zamówień"},
            {PackageStatus.Delivered, "Doręczono" },
            {PackageStatus.InSystem, "Zarejestrowano"},
            {PackageStatus.InWarehouse, "W magazynie"},
            {PackageStatus.OnTheWay, "Wysłano"}
        };

        public static string MapStatus(PackageStatus status)
        {
            return PackageStatuses[status];
        }
    }
}
