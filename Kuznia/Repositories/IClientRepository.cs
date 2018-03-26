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
        void Add(Client client);
        bool Delete(Client client);
        List<Client> GetClients();
    }
}
