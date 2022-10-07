using projDapperExample1.Model;
using projDapperExample1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapperExample1.Service
{
    public class ClientService
    {
        private IClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public bool Add(Client client)
        {
            return _clientRepository.Add(client);
        }

        public List<Client> GetAll()
        {
            return _clientRepository.GetAll();
        }
    }
}
