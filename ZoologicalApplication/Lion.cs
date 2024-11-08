using System;

namespace ZoologicalApplication;

public class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }


    public void MakeSound()
    {
        Console.WriteLine($"{Name} Kükredi!!");
    }
}
