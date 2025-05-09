using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Fishsprogram
    {
            static public ShelterFishs fishShelter = new ShelterFishs();
            public static void CreateExistingFishs()
            {
                Whaleshark newWhaleshark = new Whaleshark("kathi", 21, "whaleshark");
                Console.WriteLine(newWhaleshark);
                newWhaleshark.MakeSound();
                Tigershark newTigershark = new Tigershark("lilly", 4, "tigershark");
                Console.WriteLine(newTigershark);
                newTigershark.MakeSound();
                Stingray newStingray = new Stingray("ralph", 9, "stingray");
                Console.WriteLine(newStingray);
                newStingray.MakeSound();
                Toadfish newToadfish = new Toadfish("paul", 1, "stingray");
                Console.WriteLine(newToadfish);
                newToadfish.MakeSound();

                fishShelter.AddAnimal(newWhaleshark);
                fishShelter.AddAnimal(newTigershark);
                fishShelter.AddAnimal(newStingray);
                fishShelter.AddAnimal(newToadfish);
            }

            static void EnterNewFish()
            {
                Console.WriteLine("Please enter the species of the new animal:");
                string species = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter the name of the animal:");
                string nameNewAnimal = Console.ReadLine().ToLower();
                Console.WriteLine("Please enter the age of the animal:");
                int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int
                switch (species)
                {
                    case "whaleshark":
                        Whaleshark newWhalesharkToAdd = new Whaleshark(nameNewAnimal, ageNewAnimal, species);
                        fishShelter.AddAnimal(newWhalesharkToAdd);
                        break;
                    case "lion":
                        Tigershark newTigersharkToAdd = new Tigershark(nameNewAnimal, ageNewAnimal, species);
                        fishShelter.AddAnimal(newTigersharkToAdd);
                        break;
                    case "okapi":
                        Toad newToadToAdd = new Toad(nameNewAnimal, ageNewAnimal, species);
                        fishShelter.AddAnimal(newToadToAdd);
                        break;
                    case "cat":
                        Caecilian newCaecilianToAdd = new Caecilian(nameNewAnimal, ageNewAnimal, species);
                        fishShelter.AddAnimal(newCaecilianToAdd);
                        break;
                    default:
                        Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species);
                        fishShelter.AddAnimal(newAnimal);
                        break;
                }
            }
            static void AdoptNewAmphibian()
            {
                Console.WriteLine("Please enter the name of the animal you want to adopt:");
                string adoptedAmphibianName = Console.ReadLine().ToLower();
                fishShelter.AdoptAnimal(adoptedAmphibianName);
            }

            public void GreetNewAmphibian()
            {
                Console.WriteLine("enter the name of the species you want to greet:");
                string amphibianGreet = Console.ReadLine().ToLower();
                fishShelter.GreetAnimal(amphibianGreet);
            }
            static void RunGameAmphibian()
            {
                Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3) \n - greet animal(4)");
                string selection = Console.ReadLine().ToLower();

                switch (selection)
                {
                    case "1":
                        EnterNewAmphibian();
                        break;
                    case "2":
                        AdoptNewAmphibian();
                        break;
                    case "3":
                        fishShelter.ShowAllAnimals();
                        break;
                    case "4":
                        Amphibiansprogram amphibianprogram = new();
                        amphibianprogram.GreetNewAmphibian();
                        break;
                }
            }
        }
 
}
