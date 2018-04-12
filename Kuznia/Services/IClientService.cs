using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;

namespace Kuznia.Services
{
    public interface IClientService
    {
        void Add(Client client);
        bool Delete(Client client);
        Client Get(int clientId);
        List<Client> GetAll();
        void Update(Client client);
    }
}
