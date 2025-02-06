using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;
using UtilsLibrary;  // DLL
using POO.Interfaces;

namespace POO.Controllers
{
    public abstract class UserController : IUserController
    {
        private static readonly string ProjectRootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        private static readonly string FilePath = Path.Combine(ProjectRootPath, "user.txt");

        public int AddUser(User user)
        {
            if (!Utils.IsValidId(user.Id, FilePath))
            {
                return 0;
            }

            if (!user.IsValidEmail(user.Email))
            {
                Console.WriteLine("Invalid email");
                return 0;
            }

            if (!user.IsValidPassword(user.Password))
            {
                Console.WriteLine("Invalid password");
                return 0;
            }

            try
            {
                string content = $"{user.Id}, {user.Username}, {user.Email}, {user.Password}, {user.Role}";
                File.AppendAllText(FilePath, content + Environment.NewLine);
                Console.WriteLine("User added successfully");
                return 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return 0;
            }
        }
    }
}
