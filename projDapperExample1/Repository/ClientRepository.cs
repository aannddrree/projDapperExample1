using Dapper;
using projDapperExample1.Config;
using projDapperExample1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapperExample1.Repository
{
    public class ClientRepository : IClientRepository
    {
        private string _conn;

        public ClientRepository()
        {
            _conn = DataBaseConfiguration.Get();
        }

        public bool Add(Client client)
        {
           bool result = false;

           using(var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Client.INSERT, client);
                result = true;
            }
           return result;
        }

        public List<Client> GetAll()'
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                var clients = db.Query<Client>(Client.SELECT);
                return (List<Client>) clients;
            }
        }
    }
}
