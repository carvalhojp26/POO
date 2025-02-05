using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Stay
    {
        private int id;
        private string name;
        private string description;
        private int pricePerNight;
        private int maxGuests;
        private string city;
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public int PricePerNight
        {
            get => pricePerNight;
            set => pricePerNight = value;
        }

        public int MaxGuests
        {
            get => maxGuests;
            set => maxGuests = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public Stay(int id, string name, string description, int pricePerNight, int maxGuests, string city)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.pricePerNight = pricePerNight;
            this.maxGuests = maxGuests;
            this.city = city;
        }
    }
}
