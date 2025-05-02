﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalshelterOOP
{
    internal class Okapi:Animal
    {
        public Okapi(string name, int age, string species) : base(name, age, species) { }
        public override void MakeSound()
        {
            Console.WriteLine("chuff");
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";

        }
    }
}
