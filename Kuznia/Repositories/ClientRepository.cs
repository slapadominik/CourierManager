using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Helpers;
using Kuznia.Models;

namespace Kuznia.Repositories
{
    public class ClientRepository : IRepository<Client>
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

        public void Delete(int index)
        {
            if (index < 0 || index > _clients.Count)
                throw new IndexOutOfRangeException();
            _clients.RemoveAt(index);
            _serliazer.Serialize(_clients);
        }
 
        public Client Get(int index)
        {
            if (IndexOutOfBounds(index))
                return null;
            return _clients[index];
        }

        public void Update(int index, Client client)
        {
            if (IndexOutOfBounds(index))
                throw new IndexOutOfRangeException();
            _clients[index] = client;
            _serliazer.Serialize(_clients);
        }

        public List<Client> GetAll()
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

        private bool IndexOutOfBounds(int index)
        {
            return (index < 0 || index > _clients.Count - 1);
        }

      

    }
}
