using System;
using System.Net.Http.Headers;

public class StartUp
{
    static void Main(string[] args)
    {
        Hero hero = new Hero("Gosho");
        Dummy dummy = new Dummy(20,20);
        Console.WriteLine(dummy.Health);
        Console.WriteLine(hero.Weapon.AttackPoints);
        Console.WriteLine(hero.Weapon.DurabilityPoints);
        hero.Attack(dummy);
        Console.WriteLine(dummy.Health);
        Console.WriteLine(hero.Weapon.AttackPoints);
        Console.WriteLine(hero.Weapon.DurabilityPoints);

    }
}
