using System;

namespace ZoologicalApplication;

public class Elephant : Animal
{
    public Elephant(string name, int age, string species) : base(name, age, species)
    {

    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} Hortumladı!!");
    }
}
