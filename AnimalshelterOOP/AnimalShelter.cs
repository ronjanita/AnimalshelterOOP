using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    public class AnimalShelter
    {
        public List<Animal> animalsInShelter = new();
        
        public void AddAnimal(Animal animal)   //fügt ein tier zu liste hinzu
        {
            animalsInShelter.Add(animal);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            Animal foundAnimal = null;
            foreach (Animal animalToCheck in animalsInShelter)  // rückwerts durch lsite itieren?
            {
                if (animalToCheck.Name == searchingName)   
                {
                    foundAnimal = animalToCheck;
                }
            }
            if (foundAnimal != null)
            {
                animalsInShelter.Remove(foundAnimal);
            }

            //Animal searchedAnimal = animalsInShelter.FirstOrDefault(animalToCheck => animalToCheck.Name == searchingName);
            //animalsInShelter.Remove(searchedAnimal);
        }
        public void ShowAllAnimals()
        {
            foreach(Animal animal in animalsInShelter)
            {
                Console.WriteLine($"here are all animals currently in the shelter: {animal}");
            }
        } 
        
        public void GreetAnimal(string searchingSpecies)
        {
            Animal foundAnimal = null;
            foreach(Animal animalToCheck in animalsInShelter)
            {
                if (animalToCheck.Species == searchingSpecies)
                {
                    foundAnimal = animalToCheck;
                }
            }
            if (foundAnimal != null)
            {
                foundAnimal.MakeSound();
            }
        }
    }
}
