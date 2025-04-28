using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class AnimalShelter
    {
        List<Animal> animals;
        public void AddAnimal(Animal animal)   //fügt ein tier zu liste hinzu
        {
            Console.WriteLine("Enter animal you want to add to list:");
            Console.ReadLine();
            animals.Add(animal);
        }
        public void AdoptAnimal(string name) //entfernt ein tier anhand des namens aus der liste
        {
            Console.WriteLine("Enter animal you want to remove from list:");
            Console.ReadLine();

        }
        public void ShowAllAnimals()
        {

        }
    }
}
