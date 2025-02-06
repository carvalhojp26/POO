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

        // Testando adicionar estadias
        StayController stayController = new StayController();
        Stay stay = new Stay(1, "Casa de praia", "Casa de praia com piscina", 100, 10, "Rio de Janeiro");
        Stay stay2 = new Stay(2, "Casa de campo", "Casa de campo com lareira", 200, 5, "São Paulo");
        stayController.AddStay(stay);
        stayController.AddStay(stay2);
    }
}
