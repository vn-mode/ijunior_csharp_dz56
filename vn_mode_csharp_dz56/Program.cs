using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var soldiers = Soldier.CreateSampleSoldiers();
        var soldierService = new SoldierService();
        soldierService.DisplaySoldierNamesAndRanks(soldiers);
    }
}

public class SoldierService
{
    private const string OutputFormat = "{0} - {1}";

    public void DisplaySoldierNamesAndRanks(IEnumerable<Soldier> soldiers)
    {
        var soldierNamesAndRanks = from soldier in soldiers
                                   select new { soldier.Name, soldier.Rank };

        foreach (var item in soldierNamesAndRanks)
        {
            Console.WriteLine(string.Format(OutputFormat, item.Name, item.Rank));
        }
    }
}

public class Soldier
{
    public string Name { get; private set; }
    public string Weapon { get; private set; }
    public string Rank { get; private set; }
    public int ServiceDuration { get; private set; }

    public Soldier(string name, string weapon, string rank, int serviceDuration)
    {
        Name = name;
        Weapon = weapon;
        Rank = rank;
        ServiceDuration = serviceDuration;
    }

    public static List<Soldier> CreateSampleSoldiers()
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
