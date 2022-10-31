using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    public class Gamehandler
    {
        public BuildMode BuildMode {get;set;}
        public PlayMode PlayMode {get; set;} 
        public FamilyMode FamilyMode { get; set; }

        public Gamehandler()
        {
            BuildMode = new BuildMode();
            PlayMode = new PlayMode();
            FamilyMode = new FamilyMode();
            Menu();
        }

        public void Menu()
        {
            Console.WriteLine("1: Build Mode \n 2: PlayMode \n 3: Family Mode");
            var choice = Console.ReadLine();
            switch(choice) 
            {
                case "1":
                    BuildMode.ShowMenu();
                    break;
                case "2":
                    PlayMode.ShowMenu();
                    break;
                case "3":
                    FamilyMode.ShowMenu();
                    break;

                default:
                    break;



            }
        }

    }
}
