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
        void AddClient(Client client);
        void Delete(Client client);
        Client Get(int index);
        void Update(int index, Client client);
        List<Client> GetAll();
    }
}
