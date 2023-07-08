using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    const string OUTPUT_FORMAT = "{0} - {1}";

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

        var soldierNamesAndRanks = from soldier in soldiers
                                   select new { soldier.Name, soldier.Rank };

        foreach (var item in soldierNamesAndRanks)
        {
            Console.WriteLine(string.Format(OUTPUT_FORMAT, item.Name, item.Rank));
        }
    }
}

public class Soldier
{
    private string _name;
    private string _weapon;
    private string _rank;
    private int _serviceDuration;

    public string Name
    {
        get { return _name; }
        private set { _name = value; }
    }

    public string Weapon
    {
        get { return _weapon; }
        private set { _weapon = value; }
    }

    public string Rank
    {
        get { return _rank; }
        private set { _rank = value; }
    }

    public int ServiceDuration
    {
        get { return _serviceDuration; }
        private set { _serviceDuration = value; }
    }

    public Soldier(string name, string weapon, string rank, int serviceDuration)
    {
        Name = name;
        Weapon = weapon;
        Rank = rank;
        ServiceDuration = serviceDuration;
    }
}
