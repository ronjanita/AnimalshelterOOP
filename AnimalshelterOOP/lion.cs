using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Lion:Animal
    {
        public Lion(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("rawr");  
        }
    }
}
