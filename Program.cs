using System;
using POO.Controllers;
using POO.Models;

class Program
{
    static void Main()
    {
        ClientController clientController = new ClientController();
        AdminController adminController = new AdminController();
        // Testando adicionar clientes
        adminController.AddAdmin(3, "admbrabo", "asdasd@gmail.com", "semha1234");
        clientController.AddClient(5, "joaosilva", "joao@email.com", "senha123");
        clientController.AddClient(2, "maria", "maria@email.com", "senha456"); 
    }
}
