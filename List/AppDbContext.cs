using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class AppDbContext
    {
        public static List<Room> Rooms = new List<Room>();
        public static List<Hotel> Hotels = new List<Hotel>();


        public void AddRoom(Room room)
        {
            Rooms.Add(room);

        }
        public void AddHotel(Hotel hotel)
        {
            Hotels.Add(hotel);
        }

        public List<Hotel> Showhotel()
        {
            return Hotels;
        }

        public List<Room> Showroom()
        {
            return Rooms;
        }
        public void FindAllRoom()
        {
            foreach (Room room in Rooms)
            {
                Console.WriteLine(room.Name);
            }
        }
        public void Rezervation(string name, double capacity)
        {
            if (name == null)
            {
                throw new NullReferenceException("room bosdu");
            }
            Room room = Rooms.Find(x => x.Name == name);
            if (room == null)
            {
                throw new NotAvailableException("Otaq tapilmadi");
            }
            if (room.IsAvailable == false)
            {
                throw new NotAvailableException("Otaq elcatan deyil");
            }
            room.IsAvailable = false;
        }
    }
}
