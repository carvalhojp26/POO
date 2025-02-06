using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;
using UtilsLibrary;  // DLL

namespace POO.Controllers
{
    public abstract class UserController
    {
        private static readonly string ProjectRootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        private static readonly string FilePath = Path.Combine(ProjectRootPath, "user.txt");

        public bool IsValidId(int id, string path)
        {
            bool valid = Utils.IsValidId(id, path);
            if (!valid)
            {
                Console.WriteLine("Invalid id");
                return false;
            }
            else
            {
                Console.WriteLine("Valid id");
                return true;
            }
        }

        public int AddUser(User user)
        {
            Console.WriteLine($"📂 Salvando em: {FilePath}");

            if (!IsValidId(user.Id, FilePath))
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
