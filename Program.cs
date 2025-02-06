using System;
using POO.Controllers;
using POO.Models;

class Program
{
    static void Main()
    {
        ClientController clientController = new ClientController();
        AdminController adminController = new AdminController();
        StayController stayController = new StayController();
        BookingController bookingController = new BookingController();

        // ✅ Adding Admin and Clients
        adminController.AddAdmin(3, "admbrabo", "asdasd@gmail.com", "senha1234");
        clientController.AddClient(5, "joaosilva", "joao@email.com", "senha123");
        clientController.AddClient(2, "maria", "maria@email.com", "senha456");

        // ✅ Adding Stays
        Stay stay1 = new Stay(1, "Casa de praia", "Casa de praia com piscina", 100, 10, "Rio de Janeiro");
        Stay stay2 = new Stay(2, "Casa de campo", "Casa de campo com lareira", 200, 5, "São Paulo");
        stayController.AddStay(stay1);
        stayController.AddStay(stay2);

        // ✅ First Booking (Should Succeed)
        Booking booking1 = new Booking(1, 5, 1, new DateTime(2025, 03, 10), new DateTime(2025, 03, 15));
        bookingController.AddBooking(booking1);

        // ❌ Overlapping Booking (Should be rejected)
        Booking booking2 = new Booking(2, 2, 1, new DateTime(2025, 03, 14), new DateTime(2025, 03, 20));
        bookingController.AddBooking(booking2);

        // ✅ Non-Overlapping Booking (Should be successful)
        Booking booking3 = new Booking(3, 2, 1, new DateTime(2025, 03, 16), new DateTime(2025, 03, 18));
        bookingController.AddBooking(booking3);

        // ❌ Another Overlapping Booking (Should be rejected)
        Booking booking4 = new Booking(4, 5, 1, new DateTime(2025, 03, 15), new DateTime(2025, 03, 19));
        bookingController.AddBooking(booking4);

        // ✅ Booking in another Stay (Should work)
        Booking booking5 = new Booking(5, 5, 2, new DateTime(2025, 03, 12), new DateTime(2025, 03, 14));
        bookingController.AddBooking(booking5);
    }
}
