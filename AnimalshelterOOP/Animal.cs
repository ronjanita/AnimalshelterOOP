using System.Runtime.InteropServices.Marshalling;

namespace AnimalshelterOOP
{
    public class Animal
    {
        public string Name;
        public int Age;
        public Animal(string name, int age)
        {
            Name = name; 
            Age = age;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
        public override string ToString()
        {
            return$"{Name},{Age}years old.";
         
        }
    }

}
