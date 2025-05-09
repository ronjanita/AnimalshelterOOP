﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalshelterOOP
{
    internal class Toad:Animal
    {
        public Toad(string name, int age, string species) : base(name, age, species) { }
        public override void MakeSound()
        {
            Console.WriteLine("waahwaah");
        }
        public override string ToString()
        {
            return $"{Species},{Name},{Age}years old.";

        }
    }
}
