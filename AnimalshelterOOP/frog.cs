﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalshelterOOP
{
    internal class Frog:Animal
    {
        public Frog(string name, int age, string species) : base(name, age, species) { }
        public override void MakeSound()
        {
            Console.WriteLine("quackquack");
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";
        }
    }
}
