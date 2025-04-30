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
            Dog newDog = new("leo", 1);
            newDog.MakeSound();
            newDog.ToString();
            Lion newLion = new("rocky",44);
            newLion.MakeSound();
            newLion.ToString(); 
            Okapi newOkapi = new("rudolf mc donald", 998);
            Whaleshark newWhalshark = new("sally", 72);


            //AnimalShelter animalShelter = new();
            //animalShelter.AddAnimal(newDog);
            //animalShelter.AdoptAnimal(newOkapi);
            
        }
    }
} 
