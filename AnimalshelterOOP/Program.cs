using System.Runtime.InteropServices.Marshalling;

class Animal
{
    public string Name;
    public int Age;
    static void Main()
    {
        MakeSound();
        ToString;
    }
    public virtual void MakeSound()
    {

    }
    public override string ToString()
    {
        return Name;
    }
}
