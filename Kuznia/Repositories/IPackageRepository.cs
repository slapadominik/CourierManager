using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public interface IPackageRepository
    {
        void Add(Package package);
        bool Delete(Package package);
        Package Get(int packageId);
        List<Package> GetAll();
        void Update(Package package);
    }
}
