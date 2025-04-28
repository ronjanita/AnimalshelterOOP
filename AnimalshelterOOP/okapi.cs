using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class okapi:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("chuff");
            Name = "okapi";
        }
    }
}
