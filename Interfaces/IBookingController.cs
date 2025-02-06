using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;

namespace POO.Interfaces
{
    internal interface IBookingController
    {
        bool IsStayBooked(int stayId, DateTime arrivalDate, DateTime departureDate);
        int AddBooking(Booking booking);
    }
}
