﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Amphibiansprogram
    {
        static public ShelterAmphibians amphibianShelter = new ShelterAmphibians();
        public static void CreateExistingAmphibians()
        {
            Frog newFrog = new Frog("hans", 7, "frog");
            Console.WriteLine(newFrog);
            newFrog.MakeSound();

            Anaconda newAnaconda = new Anaconda("lisa", 2, "Anaconda");
            Console.WriteLine(newAnaconda);
            newAnaconda.MakeSound();

            Toad newToad = new Toad("peter", 6, "Toad");
            Console.WriteLine(newToad);
            newToad.MakeSound();

            Caecilian newCaecilian = new Caecilian("jasper", 10, "caecilian");
            Console.WriteLine(newCaecilian);
            newCaecilian.MakeSound();

            amphibianShelter.AddAnimal(newFrog);
            amphibianShelter.AddAnimal(newAnaconda);
            amphibianShelter.AddAnimal(newToad);
            amphibianShelter.AddAnimal(newCaecilian);
        }
        static void EnterNewAmphibian()
        {
            Console.WriteLine("Please enter the species of the new animal:");
            string species = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the name of the animal:");
            string nameNewAnimal = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter the age of the animal:");
            int ageNewAnimal = int.Parse(Console.ReadLine());   //int parse macht string in int

            switch (species)
            {
                case "frog":
                    Frog newFrogToAdd = new Frog(nameNewAnimal, ageNewAnimal, species);
                    amphibianShelter.AddAnimal(newFrogToAdd);
                    break;

                case "lion":
                    Anaconda newAnacondaToAdd = new Anaconda(nameNewAnimal, ageNewAnimal, species);
                    amphibianShelter.AddAnimal(newAnacondaToAdd);
                    break;

                case "okapi":
                    Toad newToadToAdd = new Toad(nameNewAnimal, ageNewAnimal, species);
                    amphibianShelter.AddAnimal(newToadToAdd);
                    break;

                case "cat":
                    Caecilian newCaecilianToAdd = new Caecilian(nameNewAnimal, ageNewAnimal, species);
                    amphibianShelter.AddAnimal(newCaecilianToAdd);
                    break;

                default:
                    Animal newAnimal = new Animal(nameNewAnimal, ageNewAnimal, species);
                    amphibianShelter.AddAnimal(newAnimal);
                    break;
            }
        }
        static void AdoptNewAmphibian()
        {
            Console.WriteLine("Please enter the name of the animal you want to adopt:");
            string adoptedAmphibianName = Console.ReadLine().ToLower();
            amphibianShelter.AdoptAnimal(adoptedAmphibianName);
        }
        public void GreetNewAmphibian()
        {
            Console.WriteLine("enter the name of the species you want to greet:");
            string amphibianGreet = Console.ReadLine().ToLower();
            amphibianShelter.GreetAnimal(amphibianGreet);
        }
        public void RunGameAmphibian()
        {
            Console.WriteLine("Chose between: \n - add a new animal to the shelter(1) \n - adopt an animal from the shelter(2) \n - show all animals(3) \n - greet animal(4)");
            string selection = Console.ReadLine().ToLower();
            CreateExistingAmphibians();

            switch (selection)
            {
                case "1":
                    EnterNewAmphibian();
                    break;
                case "2":
                    AdoptNewAmphibian();
                    break;
                case "3":
                    amphibianShelter.ShowAllAnimals();
                    break;
                case "4":
                    Amphibiansprogram amphibianprogram = new();
                    amphibianprogram.GreetNewAmphibian();
                    break;
            }
        }
    }
}
