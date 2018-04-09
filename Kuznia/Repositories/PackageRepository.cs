using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Helpers;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    class PackageRepository : IRepository<Package>
    {
        private readonly ISerializer<List<Package>> _serliazer;
        private List<Package> _packages;

        public PackageRepository(ISerializer<List<Package>> serializer)
        {
            _serliazer = serializer;
            InitializeClientsFromFile();
        }

        private void InitializeClientsFromFile()
        {
            _packages = _serliazer.Deserialize();
            if (_packages == null)
            {
                _packages = new List<Package>();
            }
        }

        public void Add(Package t)
        {
            _packages.Add(t);
            _serliazer.Serialize(_packages);
        }

        public void Delete(int index)
        {
            if (index < 0 || index > _packages.Count)
                throw new IndexOutOfRangeException();
            _packages.RemoveAt(index);
            _serliazer.Serialize(_packages);
        }

        public Package Get(int index)
        {
            if (IndexOutOfBounds(index))
                return null;
            return _packages[index];
        }

        public void Update(int index, Package package)
        {
            if (IndexOutOfBounds(index))
                throw new IndexOutOfRangeException();
            _packages[index] = package;
            _serliazer.Serialize(_packages);
        }

        public List<Package> GetAll()
        {
            return _packages;
        }

        private bool IndexOutOfBounds(int index)
        {
            return (index < 0 || index > _packages.Count - 1);
        }
    }
}
