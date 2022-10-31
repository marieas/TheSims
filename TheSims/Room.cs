using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class Room
    { 
        List<InteriorItem> Interior { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }

        public Room(string name, string id)
        {
            Name = name;
            Id = id;
        }
       public void ShowFurniture()
       {

       }
    }
}
