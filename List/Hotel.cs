using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Hotel
    {
        private double _id = 1;
        public string Name { get; set; }
        public double Id { get; set; }
        public Hotel(string name)
        {
            Name = name;
            Id = ++_id;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine($"Name:{Name},Id:{Id}");
        }
        public string ToString()
        {
            return $"Name:{Name}";
        }

    }
}
