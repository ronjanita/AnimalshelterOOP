using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Whaleshark:Animal
    {
        public Whaleshark(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine("gluckgluck");
        }
    }
}
