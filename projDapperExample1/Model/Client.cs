using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projDapperExample1.Model
{
    public class Client
    {
        #region Constant
        public readonly static string INSERT = "INSERT INTO TB_CLIENT  (Name, Telephone) VALUES (@Name, @Telephone)";
        public readonly static string SELECT = "SELECT Id, Name, Telephone FROM TB_CLIENT";
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        #endregion

        #region Method
        public override string ToString()
        {
            return "Id: " + this.Id + 
                 "\nNome: " + this.Name + 
                 "\nTelefone: " + this.Telephone;
        }
        #endregion
    }
}
