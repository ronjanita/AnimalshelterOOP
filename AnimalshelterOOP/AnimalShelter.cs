using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class AnimalShelter
    {
        public List<Animal> animalsInShelter = new List<Animal>();
        
        public void AddAnimal(Animal animal)   //fügt ein tier zu liste hinzu
        {
            animalsInShelter.Add(animal);
        }
        public void AdoptAnimal(string searchingName) //entfernt ein tier anhand des namens aus der liste
        {
            foreach (Animal animalToCheck in animalsInShelter)
            {
                if (animalToCheck.Name == searchingName)
                {
                    animalsInShelter.Remove(animalToCheck);
                }
            }
        }
        public void ShowAllAnimals()
        {
            Console.WriteLine($"here are all animals currently in the shelter: {animalsInShelter}");
        }
    }
}
