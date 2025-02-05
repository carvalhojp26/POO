using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Interfaces;

namespace POO.Models
{
    public abstract class User : IUserModel
    {
        private int id;
        private string username;
        private string email;
        private string password;
        private string role;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Role
        {
            get => role;
            set => role = value;
        }

        public User(int id, string username, string email, string password, string role)
        {
            this.id = id;
            this.username = username;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public bool IsValidEmail(string email)
        {
            if (email == null)
            {
                return false;
            }

            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(trimmedEmail);
                return addr.Address == trimmedEmail;
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            if (password == null)
            {
                return false;
            }

            var trimmedPassword = password.Trim();

            if (trimmedPassword.Length < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
