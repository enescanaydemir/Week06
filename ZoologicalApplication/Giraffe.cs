using System;

namespace ZoologicalApplication;

public class Giraffe : Animal
{
    public Giraffe(string name, int age, string species) : base(name, age, species)
    {
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} Bağırdı!!!");
    }
}
