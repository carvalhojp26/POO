using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Client : User
    {
        public Client(int id, string username, string email, string password) : base(id, username, email, password, "client")
        {
        }
    }
}
