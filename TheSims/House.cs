using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class House
    {
        public List<Floor> Floors { get; set; }
        public House()
        {
            Floors = new List<Floor>();         
        }
            
        public void AddFloors(int levels)
        {
            for(int i = 0; i<levels; i++)
            {
                Floors.Add(new Floor(i));
            }
        }
        public void AddRoom(Room room, Floor floor)
        {
            floor.AddRoomToFloor(room);
        }

        public Floor GetFirstFloor()
        {
            return Floors[0];
        }
      
    }
}
