using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Interfaces;

namespace POO.Models
{
    public class Booking : IBookingModel
    {
        private int id;
        private int userId;
        private int stayId;
        private DateTime arrivalDate;
        private DateTime departureDate;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public int StayId
        {
            get => stayId;
            set => stayId = value;
        }

        public DateTime ArrivalDate
        {
            get => arrivalDate;
            set => arrivalDate = value;
        }

        public DateTime DepartureDate
        {
            get => departureDate;
            set => departureDate = value;
        }

        public Booking(int id, int userId, int stayId, DateTime arrivalDate, DateTime departureDate)
        {
            this.id = id;
            this.userId = userId;
            this.stayId = stayId;
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        public bool IsValidBooking()
        {
            return arrivalDate < departureDate;
        }

        public int GetTotalNights()
        {
            TimeSpan duration = departureDate - arrivalDate;
            return duration.Days;
        }
    }
}
