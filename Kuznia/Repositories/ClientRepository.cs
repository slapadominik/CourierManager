using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Helpers;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ISerializer<List<Client>> _serliazer;
        private List<Client> _clients;

        public ClientRepository(ISerializer<List<Client>> serializer)
        {
            _serliazer = serializer;
            InitializeClientsFromFile();
            
        }

        public void Add(Client client)
        {
            _clients.Add(client);
            _serliazer.Serialize(_clients);
        }

        public bool Delete(Client client)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClients()
        {
            return _clients;
        }

        private void InitializeClientsFromFile()
        {
            _clients = _serliazer.Deserialize();
            if (_clients == null)
            {
                _clients = new List<Client>();
            }
        }

      

    }
}
