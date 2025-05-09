﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    public class ShelterAmphibians
    {
        public List<Animal> amphibiansInShelter = new();

        public void AddAnimal(Animal amphibians)   //fügt ein tier zu liste hinzu
        {
            amphibiansInShelter.Add(amphibians);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            Animal foundAmphibians = null;
            foreach (Animal amphibiansToCheck in amphibiansInShelter)  // rückwerts durch lsite itieren?
            {
                if (amphibiansToCheck.Name == searchingName)
                {
                    foundAmphibians = amphibiansToCheck;
                }
            }
            if (foundAmphibians != null)
            {
                amphibiansInShelter.Remove(foundAmphibians);
            }

            //Animal searchedAnimal = animalsInShelter.FirstOrDefault(animalToCheck => animalToCheck.Name == searchingName);
            //animalsInShelter.Remove(searchedAnimal);
        }
        public void ShowAllAnimals()
        {
            foreach (Animal animal in amphibiansInShelter)
            {
                Console.WriteLine($"here are all animals currently in the shelter: {animal}");
            }
        }

        public void GreetAnimal(string searchingSpecies)
        {
            Animal foundAmphibians = null;
            foreach (Animal animalToCheck in amphibiansInShelter)
            {
                if (animalToCheck.Species == searchingSpecies)
                {
                    foundAmphibians = animalToCheck;
                }
            }
            if (foundAmphibians != null)
            {
                foundAmphibians.MakeSound();
            }
        }
    }
}
