using System.Collections.Generic;
using UnityEngine;

public interface PeopleINPC
{
    string Speak();
    string GetDescription();
    List<int> GetStats();
}

public class Cityboy : PeopleINPC
{
    int intel, strength;
    public string Speak()
    {
        return "Sup bro";
    }
    public string GetDescription()
    {
        return "Cityboy";
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

public class Cowboy : PeopleINPC
{
    int intel, strength;
    public string Speak()
    {
        return "Howdy";
    }
    public string GetDescription()
    {
        return "Cowboy";
    }
    public List<int> GetStats()
    {
        intel = 3;
        strength = 10;
        List<int> stats = new List<int>();
        stats.Add(intel);
        stats.Add(strength);

        return stats;
    }
}

public class Weenie : PeopleINPC
{
    int intel, strength;
    public string Speak()
    {
        return "I can't wait to do some protracting";
    }
    public string GetDescription()
    {
        return "Weenie";
    }
    public List<int> GetStats()
    {
        intel = 5;
        strength = 5;
        List<int> stats = new List<int>();
        stats.Add(intel);
        stats.Add(strength);

        return stats;
    }
}