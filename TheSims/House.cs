using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class House
    {
        List<Floor> Floors { get; set; }
        public House()
        {
            Floors = new List<Floor>();
            Floors.Add(new Floor());
        }

        public Floor GetFirstFloor()
        {
            return Floors[0];
        }
    }
}
