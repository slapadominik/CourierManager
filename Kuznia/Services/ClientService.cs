using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Models;
using Kuznia.Repositories;

namespace Kuznia.Services
{
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> _repository;

        public ClientService(IRepository<Client> repository)
        {
            _repository = repository;
        }

        public void AddClient(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client mustn't be null");
            }
            _repository.Add(client);
        }

        public void Delete(Client client)
        {
            if (client == null)
            {
                throw new ArgumentException("Client mustn't be null");
            }
            
        }

        public Client Get(int index)
        {
            return _repository.Get(index);
        }

        public void Update(int index, Client client)
        {
            
        }

        public List<Client> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
