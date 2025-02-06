using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces
{
    internal interface IUserModel
    {
        bool IsValidEmail(string email);
        bool IsValidPassword(string password);
    }
}
