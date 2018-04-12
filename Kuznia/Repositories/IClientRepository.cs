using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public interface IClientRepository
    {
        void Add(Client package);
        bool Delete(Client client);
        Client Get(int clientId);
        List<Client> GetAll();
        void Update(Client client);
    }
}
