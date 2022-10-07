using projDapperExample1.Model;
using projDapperExample1.Service;
using System;

namespace projDapperExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            Client client = new Client()
            {
                Name = "Teste",
                Telephone = "16 988882222"
            };

            new ClientService().Add(client);

            new ClientService().GetAll().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ufa!");
        }
    }
}
