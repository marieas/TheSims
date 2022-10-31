using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    /* Du kan bygge opp et hus ved å legge til ferdigdefinerte rom i huset ditt:

            Kjøkken
            Bad
            Stue
            Soverom

            Du kan legge til hvor mange av de forskjellige rommene du ønsker i huset,
            eventuelt fordelt på flere etasjer i huset.
            Du kan dekorere rommene med ferdigdefinert innhold:

            Bord
            Kjøleskap
            Vask
            Oppvaskmaskin
            Vaskemaskin
            Seng
            Sofa
            TV
            PC*/ 
    public class BuildMode
    {   public House House { get; set; }
        List<Room> AvailableRooms { get; set; }
        // pause til 13.07 

        public BuildMode()
        {
            AvailableRooms = new List<Room>();
            AvailableRooms.Add(new Kitchen());
            AvailableRooms.Add(new Bathroom());
            AvailableRooms.Add(new LivingRoom());
            House = new House();

        }

        public void PrintAvailableRooms()
        {
            foreach (var room in AvailableRooms)
            {
                Console.WriteLine($"Roomtype: {room.Name} RoomId: {room.Id}");
            }
           
        }
        public void ShowMenu()
        {
           
            var firstFloor = House.GetFirstFloor();
            bool inMenu = true;
            while (true)
            {
                Console.WriteLine("Welcome to build mode, what room do you want to add? x for exit");
                PrintAvailableRooms();
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        firstFloor.AddRoomToFloor(new Kitchen());
                        break;
                    case "2":
                        firstFloor.AddRoomToFloor(new Bathroom());
                        break;
                    case "3":
                        firstFloor.AddRoomToFloor(new Bedroom());
                        break;
                    default:
                        firstFloor.PrintRooms();
                        return;                       
                }                
            }
            
            }
    }
}
