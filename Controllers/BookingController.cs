using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;
using POO.Interfaces;
using UtilsLibrary;

namespace POO.Controllers
{
    public class BookingController : IBookingController
    {
        private static readonly string ProjectRootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        private static readonly string FilePath = Path.Combine(ProjectRootPath, "booking.txt");
        private static readonly string UserPath = Path.Combine(ProjectRootPath, "user.txt");
        private static readonly string StayPath = Path.Combine(ProjectRootPath, "stay.txt");

        public bool IsStayBooked(int stayId, DateTime arrivalDate, DateTime departureDate)
        {
            if (!File.Exists(FilePath))
            {
                return false;
            }
            string[] bookings = File.ReadAllLines(FilePath);

            foreach (string line in bookings)
            {
                string[] fields = line.Split(", ");

                int existingStayId = int.Parse(fields[2]);
                DateTime existingArrival = DateTime.Parse(fields[3]);
                DateTime existingDeparture = DateTime.Parse(fields[4]);

                if (existingStayId == stayId)
                {
                    bool overlaps =
                        (arrivalDate < existingDeparture && departureDate > existingArrival) || // Starts before the existing one ends
                        (arrivalDate >= existingArrival && arrivalDate < existingDeparture) || // Starts within the existing one
                        (departureDate > existingArrival && departureDate <= existingDeparture); // Ends within the existing one

                    if (overlaps)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public int AddBooking(Booking booking)
        {
            if(!Utils.IsValidId(booking.Id, FilePath))
            {
                Console.WriteLine("Invalid booking id");
                return 0;
            }

            if (Utils.IsValidId(booking.UserId, UserPath)) // The ID have to exist in the file
            {
                Console.WriteLine("Invalid user id while making booking (Does not exist)");
                return 0;
            }

            if (Utils.IsValidId(booking.StayId, StayPath)) // The ID have to exist in the file
            {
                Console.WriteLine("Invalid stay id while making booking (Does not exist)");
                return 0;
            }

            if (booking.ArrivalDate < DateTime.Now || !booking.IsValidDate())
            {
                Console.WriteLine("Invalid dates");
                return 0;
            }

            if (IsStayBooked(booking.StayId, booking.ArrivalDate, booking.DepartureDate))
            {
                Console.WriteLine("Stay is already booked for the selected dates");
                return 0;
            }

            try
            {
                string content = $"{booking.Id}, {booking.UserId}, {booking.StayId}, {booking.ArrivalDate}, {booking.DepartureDate}";
                File.AppendAllText(FilePath, content + Environment.NewLine);
                Console.WriteLine("Booking added successfully");
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
