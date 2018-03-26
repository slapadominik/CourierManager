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
        void Delete(Client client);
        void Delete(int index);
        Client Get(int index);
        void UpdateClient(int index, Client client);
        List<Client> GetClients();
    }
}
