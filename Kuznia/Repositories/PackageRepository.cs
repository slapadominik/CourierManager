using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Helpers;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private readonly ISerializer<List<Package>> _serializer;
        private List<Package> _packages;

        public PackageRepository(ISerializer<List<Package>> serializer)
        {
            _serializer = serializer;
            InitializePackagesFromFile();
        }

        public void Add(Package package)
        {
            _packages.Add(package);
            _serializer.Serialize(_packages);
        }

        public bool Delete(Package package)
        {
            Package packageToDelete = Get(package.PackageId);
            if (_packages.Remove(packageToDelete))
            {
                _serializer.Serialize(_packages);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Package Get(int packageId)
        {
            return _packages.SingleOrDefault(x => x.PackageId == packageId);
        }

        public List<Package> GetAll()
        {
            return _packages;
        }

        public void Update(Package package)
        {
            int index = GetIndex(package);
            if (index >= 0)
            {
                _packages[index] = package;
                _serializer.Serialize(_packages);
            }
            else
            {
                throw new InvalidOperationException("Nie ma paczki o podanym Id");
            }
        }

        private int GetIndex(Package package)
        {
            return _packages.FindIndex(x => x.PackageId == package.PackageId);
        }

        private void InitializePackagesFromFile()
        {
            _packages = _serializer.Deserialize();
            if (_packages == null)
            {
                _packages = new List<Package>();
            }
        }
    }
}
