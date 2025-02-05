using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Admin : User
    {   
        public Admin(int id, string username, string email, string password) : base(id, username, email, password, "admin")
        {
        }
    }
}
