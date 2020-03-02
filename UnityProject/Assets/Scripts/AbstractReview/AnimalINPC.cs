using System.Collections.Generic;
using UnityEngine;

public interface AnimalINPC
{
    string Speak();
    string GetDescription();
    List<int> GetStats();
}

public class Horse : AnimalINPC
{
    int intel, strength;
    public string Speak()
    {
        return "Neigh";
    }
    public string GetDescription()
    {
        return "Horse";
    }
    public List<int> GetStats()
    {
        intel = 10;
        strength = 3;
        List<int> stats = new List<int>();
        stats.Add(intel);
        stats.Add(strength);

        return stats;
    }
}

public class Bull : AnimalINPC
{
    int intel, strength;
    public string Speak()
    {
        return "Mooooooo";
    }
    public string GetDescription()
    {
        return "Bull";
    }
    public List<int> GetStats()
    {
        intel = 3;
        strength = 9;
        List<int> stats = new List<int>();
        stats.Add(intel);
        stats.Add(strength);

        return stats;
    }
}

public class WienerDog : AnimalINPC
{
    int intel, strength;
    public string Speak()
    {
        return "Woof";
    }
    public string GetDescription()
    {
        return "WienerDog";
    }
    public List<int> GetStats()
    {
        intel = 6;
        strength = 3;
        List<int> stats = new List<int>();
        stats.Add(intel);
        stats.Add(strength);

        return stats;
    }
}