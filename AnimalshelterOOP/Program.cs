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
            Console.WriteLine("Welcome to the Animal shelter");
            Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3)");
            string selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    Console.WriteLine("Please enter the species of the new animal:");
                    string species = Console.ReadLine();
                    Console.WriteLine("Please enter the name of the animal:");
                    string nameNewAnimal = Console.ReadLine();
                    Console.WriteLine("Please enter the age of the animal:");
                    int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int
                    Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species );
                    break;
                case "2":
                    Console.WriteLine("Please enter the name of the animal you want to adopt:");
                    string adoptedAnimal = Console.ReadLine();
                    AnimalShelter removeAnimalFromList = new AnimalShelter();
                    removeAnimalFromList.AdoptAnimal("leo");
                    removeAnimalFromList.AdoptAnimal("rocky");
                    removeAnimalFromList.AdoptAnimal("rudolf mc donald");
                    removeAnimalFromList.AdoptAnimal("sally");
                    removeAnimalFromList.AdoptAnimal("sally");
                    break;
                case "3":
                    AnimalShelter animalShelter1 = new AnimalShelter();
                    animalShelter1.ShowAllAnimals();
                    break;
            }























            Dog newDog = new("leo", 1, "dog");
            newDog.MakeSound();
            newDog.ToString();
            Lion newLion = new("rocky",44, "lion");
            newLion.MakeSound();
            newLion.ToString(); 
            Okapi newOkapi = new("rudolf mc donald", 998, "okapi");
            newOkapi.MakeSound();
            newOkapi.ToString();
            Whaleshark newWhalshark = new("sally", 72, "whaleshark");
            newWhalshark.MakeSound();
            newWhalshark.ToString();

            AnimalShelter animalShelter = new();
            animalShelter.AddAnimal(newDog);
            animalShelter.AddAnimal(newLion);
            animalShelter.AddAnimal(newOkapi);
            animalShelter.AddAnimal(newWhalshark);


        }
    }
} 
