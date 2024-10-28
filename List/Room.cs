using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Room
    {
        private double _id = 1;
        private double _personcapacity;
        public string Name { get; set; }
        public double Price { get; set; }
        public double Personcapacity
        {
            get
            {
                return _personcapacity;
            }
            set
            {
                _personcapacity = value;
            }
        }
        public bool IsAvailable { get; set; }

        public double Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public Room(string name, double price, double personcapacity)
        {
            Id = _id++;
            Name = name;
            Price = price;
            Personcapacity = personcapacity;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{Id},Name:{Name},Price:{Price},PersonCapacity:{Personcapacity}");
        }
    }
