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
        static public AnimalShelter animalShelter = new AnimalShelter();

        static void Main()
        {
            bool playAgain = true;
            Console.WriteLine("Welcome to the Animal shelter");
            CreateExistingAnimals();
            while (playAgain)
            {
                RunGame();
                Console.WriteLine("Do you want to end this program? y/n");
                string input = Console.ReadLine().ToLower();

                if(input == "y")
                {
                    playAgain = false;
                }
            }
        }

        public static void CreateExistingAnimals()
        {
            Dog newDog = new("leo", 1, "dog");
            Console.WriteLine(newDog);
            newDog.MakeSound();
            Lion newLion = new("rocky", 44, "lion");
            Console.WriteLine(newLion);
            newLion.MakeSound();
            Okapi newOkapi = new("rudolf mc donald", 998, "okapi");
            Console.WriteLine(newOkapi);
            newOkapi.MakeSound();
            Whaleshark newWhalshark = new("sally", 72, "whaleshark");
            Console.WriteLine(newWhalshark);
            newWhalshark.MakeSound();

            animalShelter.AddAnimal(newDog);
            animalShelter.AddAnimal(newLion);
            animalShelter.AddAnimal(newOkapi);
            animalShelter.AddAnimal(newWhalshark);
        }

        static void EnterNewAnimal()
        {
            Console.WriteLine("Please enter the species of the new animal:");
            string species = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the name of the animal:");
            string nameNewAnimal = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the age of the animal:");
            int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int
            switch(species)
            {
                case "dog":
                    Dog newDogToAdd= new Dog(nameNewAnimal, ageNewAnimal, species);
                    animalShelter.AddAnimal(newDogToAdd);
                    break;
                case "lion":
                    Lion newLionToAdd= new Lion(nameNewAnimal, ageNewAnimal, species);
                    animalShelter.AddAnimal(newLionToAdd);
                    break;
                case "okapi":
                    Okapi newOkapiToAdd = new Okapi(nameNewAnimal, ageNewAnimal, species);
                    animalShelter.AddAnimal(newOkapiToAdd);
                    break;
                case "whaleshark":
                    Whaleshark newWhalesharkToAdd= new Whaleshark(nameNewAnimal,ageNewAnimal, species);
                    animalShelter.AddAnimal(newWhalesharkToAdd);
                    break;
                default:
                    Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species);
                    animalShelter.AddAnimal(newAnimal);
                    break;
            }
        }
        static void AdoptNewAnimal()
        {
            Console.WriteLine("Please enter the name of the animal you want to adopt:");
            string adoptedAnimalName = Console.ReadLine().ToLower();
            animalShelter.AdoptAnimal(adoptedAnimalName);
        }

        public void GreetNewAnimal()
        {
            Console.WriteLine("enter the name of the species you want to greet:");
            string animalGreet = Console.ReadLine().ToLower();
            animalShelter.GreetAnimal(animalGreet);
        }

        static void RunGame()
        {
            Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3) \n - greet animal(4)");
            string selection = Console.ReadLine().ToLower();

            switch (selection)
            {
                case "1":
                    EnterNewAnimal();
                    break;
                case "2":
                    AdoptNewAnimal();
                    break;
                case "3":
                    animalShelter.ShowAllAnimals();
                    break;
                case "4":
                    Program program = new();
                    program.GreetNewAnimal();
                    break;
            }
        }
    }
} 
