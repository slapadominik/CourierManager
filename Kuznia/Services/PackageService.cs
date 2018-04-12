using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;
using Kuznia.Repositories;

namespace Kuznia.Services
{
    public class PackageService : IPackageService
    {
        private readonly IPackageRepository _repository;
        public PackageService(IPackageRepository repository)
        {
            _repository = repository;
        }

        public void Add(Package package)
        {
            _repository.Add(package);
        }

        public bool Delete(Package package)
        {
            return _repository.Delete(package);
        }

        public Package Get(int packageId)
        {
            return _repository.Get(packageId);
        }

        public List<Package> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Package package)
        {
            _repository.Update(package);
        }
    }
}
