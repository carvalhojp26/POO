using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.Models;
using UtilsLibrary;
using POO.Interfaces;

namespace POO.Controllers
{
    public class StayController : IStayController
    {
        private static readonly string ProjectRootPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        private static readonly string FilePath = Path.Combine(ProjectRootPath, "stay.txt");
        public int AddStay(Stay stay)
        {
            if(!Utils.IsValidId(stay.Id, FilePath))
            {
                return 0;
            }

            if (stay.PricePerNight < 0)
            {
                Console.WriteLine("Invalid price per night");
                return 0;
            }

            if (stay.MaxGuests <= 0)
            {
                Console.WriteLine("Invalid max guests");
                return 0;
            }

            if (stay.City == null)
            {
                Console.WriteLine("Invalid city");
                return 0;
            }

            if (stay.Name == null)
            {
                Console.WriteLine("Invalid name");
                return 0;
            }

            if (stay.Description == null)
            {
                Console.WriteLine("Invalid description");
                return 0;
            }

            try
            {
                string content = $"{stay.Id}, {stay.Name}, {stay.Description}, {stay.PricePerNight}, {stay.MaxGuests}, {stay.City}";
                File.AppendAllText(FilePath, content + Environment.NewLine);
                Console.WriteLine("Stay added successfully");
                return 1;
            } catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return 0;
            }
        }
    }
}
