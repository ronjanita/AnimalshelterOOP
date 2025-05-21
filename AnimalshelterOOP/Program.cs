using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalshelterOOP
{
    internal class Program
    {

        static void Main()
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("Welcome to the Animal shelter, choose between the three animalshelters to continue. \n -Mammalshelter (1) \n -Amphibianshelter(2) \n -Fishshelter(3)");
                string userChoose = Console.ReadLine();
                switch (userChoose)
                {
                    case "1":
                        Mammalprogram programmammal = new();
                        programmammal.RunGameMammal();
                        break;
                    case "2":
                        Amphibiansprogram programamphibian = new();
                        programamphibian.RunGameAmphibian();
                        break;
                    case "3":
                        Fishsprogram programfish = new();
                        programfish.RunGameFish();
                        break;
                }
                
                Console.WriteLine("Do you want to end this program? y/n");
                string input = Console.ReadLine().ToLower();

                if(input == "y")
                {
                    playAgain = false;
                }
            }
        }
    }
} 
