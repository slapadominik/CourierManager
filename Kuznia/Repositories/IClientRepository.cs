using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    interface IClientRepository
    {
        void Add(Client package);
        bool Delete(Client client);
        Package Get(int packageId);
        List<Package> GetAll();
        void Update(Client client);
    }
}
