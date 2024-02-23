using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Soldier> soldiers = new List<Soldier>
        {
            new Soldier("Алексей", "Винтовка", "Рядовой", 12),
            new Soldier("Иван", "Пистолет", "Сержант", 24),
            new Soldier("Петр", "Снайперская винтовка", "Капитан", 36),
            new Soldier("Николай", "Винтовка", "Лейтенант", 48),
            new Soldier("Томас", "Винтовка", "Майор", 60)

        };

        var newSoldiers = soldiers.Select(soldier => new
        {
            Info = soldier.Name + " - " + soldier.Rank
        }
        ).ToList();

        foreach (var soldier in newSoldiers)
        {
            Console.WriteLine(soldier.Info);
        }
    }
}

public class Soldier
{
    public Soldier(string name, string weapon, string rank, int serviceDuration)
    {
        Name = name;
        Weapon = weapon;
        Rank = rank;
        ServiceDuration = serviceDuration;
    }

    public string Name { get; }
    public string Weapon { get; }
    public string Rank { get; }
    public int ServiceDuration { get; }
}