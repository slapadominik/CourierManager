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

        public Client Get(int clientId)
        {
            return _clients.SingleOrDefault(x => x.ClientId == clientId);
        }


        public List<Client> GetAll()
        {
            return _clients;
        }

        public void Update(Client client)
        {
            int index = GetIndex(client);
            if (index >= 0)
            {
                _clients[index] = client;
                _serliazer.Serialize(_clients);
            }
            else
            {
                throw new InvalidOperationException("Nie ma paczki o podanym Id");
            }
        }

        public bool Delete(Client client)
        {
            Client clientToDelete = Get(client.ClientId);
            if (_clients.Remove(clientToDelete))
            {
                _serliazer.Serialize(_clients);
                return true;
            }
            else
            {
                return false;
            }
        }

        private int GetIndex(Client client)
        {
            return _clients.FindIndex(x => x.ClientId == client.ClientId);
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
