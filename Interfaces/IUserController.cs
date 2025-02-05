using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    internal interface IUserController
    {
        public bool IsValidId(int id);
        public int AddUser(int id, string username, string email, string password, string role);
    }
}
