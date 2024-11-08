using System;

namespace GameCharactersApplication;

public class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health)
    {
    }

    public string SwordAttack { get; set; }
}
