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
        private readonly IClientRepository _repository;

        public ClientService(IClientRepository repository)
        {
            _repository = repository;
        }

        public void Add(Client client)
        {
            _repository.Add(client);
        }

        public bool Delete(Client client)
        {
            return _repository.Delete(client);
        }

        public Client Get(int clientId)
        {
            return _repository.Get(clientId);
        }

        public List<Client> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Client client)
        {
            _repository.Update(client);
        }
    }
}
