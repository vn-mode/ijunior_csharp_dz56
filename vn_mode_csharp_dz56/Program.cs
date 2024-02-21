using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        SoldierFactory soldierFactory = new SoldierFactory();
        IEnumerable<Soldier> soldiers = soldierFactory.CreateSampleSoldiers();
        SoldierService soldierService = new SoldierService();

        var simpleSoldiers = soldierService.GetSimpleSoldiers(soldiers);

        foreach (var simpleSoldier in simpleSoldiers)
        {
            Console.WriteLine($"{simpleSoldier.Name} - {simpleSoldier.Rank}");
        }
    }
}

public class SoldierFactory
{
    public List<Soldier> CreateSampleSoldiers()
    {
        return new List<Soldier>
        {
            new Soldier("Алексей", "Винтовка", "Рядовой", 12),
            new Soldier("Иван", "Пистолет", "Сержант", 24),
            new Soldier("Петр", "Снайперская винтовка", "Капитан", 36),
            new Soldier("Николай", "Винтовка", "Лейтенант", 48),
            new Soldier("Томас", "Винтовка", "Майор", 60)
        };
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

public class SoldierService
{
    public IEnumerable<(string Name, string Rank)> GetSimpleSoldiers(IEnumerable<Soldier> soldiers)
    {
        return soldiers.Select(soldier => (soldier.Name, soldier.Rank));
    }
}
