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
        List<InteriorItem> InteriorItems;
        public BuildMode()
        {
            AvailableRooms = new List<Room>();
            AvailableRooms.Add(new Kitchen());
            AvailableRooms.Add(new Bathroom());
            AvailableRooms.Add(new LivingRoom());
            House = new House();
            InteriorItems = new List<InteriorItem> {
                new Bed(),
                new Tv(),
                new Fridge(),
            };
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
                Console.WriteLine("Welcome to build mode, build house: b, decorate: d");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "b":
                        BuildMenu();
                        break;
                    case "d":
                        DecorateMenu();
                        break;

                }
                    
            }
            
        }

        private void DecorateMenu()
        {

        }

        private void BuildMenu()
        {
            Console.WriteLine("how many floors do you want? x for exit");
            var numFloors = Console.ReadLine();
            var convertedNumFloors = Convert.ToInt32(numFloors);
            House.AddFloors(convertedNumFloors);

            Console.WriteLine("what level do you want to edit? x for exit");
            var levelToEditInput = Console.ReadLine();
            var converteLevelToEditInput = Convert.ToInt32(levelToEditInput);

            RoomMenu(converteLevelToEditInput);
        }

        private void RoomMenu(int level)
        {
            var floorToEdit = House.Floors[level];

            PrintAvailableRooms();
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    House.AddRoom(new Kitchen(), floorToEdit);
                    break;
                case "2":
                    House.AddRoom(new Bathroom(), floorToEdit);
                    break;
                case "3":
                    House.AddRoom(new Bedroom(), floorToEdit);
                    break;
                default:
                    floorToEdit.PrintRooms();
                    return;
            }
        }
    }
}
