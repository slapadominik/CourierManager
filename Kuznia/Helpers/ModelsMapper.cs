using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;
using Kuznia.ViewModels;

namespace Kuznia.Helpers
{
    public static class ModelsMapper
    {
        public static List<PackageViewModel> MapPackagesToViewModel(this List<Package> packages)
        {
            return packages.Select(x => 
                new PackageViewModel(){PackageId = x.PackageId, Status = EnumMapper.MapStatus(x.Status), DeliveryDateTime = x.DeliveryDateTime}).ToList();
        }

        public static List<ClientViewModel> MapClientsToViewModel(this List<Client> clients)
        {
            return clients.Select(x =>
                new ClientViewModel() { FirstName= x.FirstName, LastName = x.LastName, City = x.City, Street = x.Street, Status = EnumMapper.MapStatus(x.Status) }).ToList();
        }
    }
}
