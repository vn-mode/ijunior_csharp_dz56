﻿using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<Soldier> soldiers = Soldier.CreateSampleSoldiers();
        SoldierService soldierService = new SoldierService();
        soldierService.DisplaySoldierNamesAndRanks(soldiers);
    }
}

public class Soldier
{
    private string _name;
    private string _weapon;
    private string _rank;
    private int _serviceDuration;

    public Soldier(string name, string weapon, string rank, int serviceDuration)
    {
        _name = name;
        _weapon = weapon;
        _rank = rank;
        _serviceDuration = serviceDuration;
    }

    public string Name { get { return _name; } private set { _name = value; } }
    public string Weapon { get { return _weapon; } private set { _weapon = value; } }
    public string Rank { get { return _rank; } private set { _rank = value; } }
    public int ServiceDuration { get { return _serviceDuration; } private set { _serviceDuration = value; } }

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

public class SoldierService
{
    public void DisplaySoldierNamesAndRanks(IEnumerable<Soldier> soldiers)
    {
        foreach (var soldier in soldiers)
        {
            Console.WriteLine($"{soldier.Name} - {soldier.Rank}");
        }
    }
}
