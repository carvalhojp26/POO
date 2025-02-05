using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;

namespace POO.Controllers
{
    public class AdminController : UserController
    {
        public int AddAdmin(int id, string username, string email, string password)
        {
            Admin admin = new Admin(id, username, email, password);
            return AddUser(admin);
        }
    }
}
