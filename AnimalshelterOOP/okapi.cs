using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Okapi:Animal
    {
        public Okapi(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("chuff");
        }
    }
}
