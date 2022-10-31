using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class Floor
    {
        List<Room> Rooms { get; set; }

        public Floor()
        {
            Rooms = new List<Room>();
        }
        public void AddRoomToFloor(Room roomToAdd)
        {
            Rooms.Add(roomToAdd);
        }
        public void PrintRooms()
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine(room.Name);
            }
        }
    }
}
