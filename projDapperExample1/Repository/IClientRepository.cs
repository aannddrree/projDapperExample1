using projDapperExample1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapperExample1.Repository
{
    public interface IClientRepository
    {
        bool Add(Client client);
        List<Client> GetAll();
    }
}
