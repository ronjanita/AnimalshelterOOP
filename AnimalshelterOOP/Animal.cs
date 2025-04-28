using System.Runtime.InteropServices.Marshalling;

class Animal
{
    public string Name;
    public int Age;
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
    public override string ToString()
    {
        Console.WriteLine($"{Name},{Age}years old.");
        return Name;
    }
}
