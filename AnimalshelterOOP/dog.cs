using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
   public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("wuff");
        }
    }
}
