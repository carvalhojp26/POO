using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;

namespace POO.Controllers
{
    public class ClientController : UserController
    {
        public int AddClient(int id, string username, string email, string password)
        {
            Client client = new Client(id, username, email, password);
            return AddUser(client);
        }
    }
}
