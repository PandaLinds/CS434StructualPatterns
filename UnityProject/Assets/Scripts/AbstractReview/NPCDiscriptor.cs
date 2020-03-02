using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PersonNPCDecorator : PeopleINPC
{
    PeopleINPC _person;

    protected string _discription = "No additions";
    protected string _speak = "Nothing more";
    protected List<int> _stats;
    // Start is called before the first frame update
    public PersonNPCDecorator(PeopleINPC person)
    {
        _person = person;
        _stats = person.GetStats();
    }

    public string Speak()
    {
        return string.Format("{0}, {1}", _person.Speak(), _speak);
    }
    public string GetDescription()
    {
        return string.Format("{0}, {1}", _person.GetDescription(), _discription);
    }

    public List<int> GetStats()
    {
        return _stats;
    }
}

public class NVGDecorator : PersonNPCDecorator
{
    public NVGDecorator(PeopleINPC person) : base(person)
    {
        _discription = "with NVGs";
        _speak = "Now I can spy in the night";
        _stats[0] += 3;
    }
}

public class CleatsDecorator : PersonNPCDecorator
{
    public CleatsDecorator(PeopleINPC person) : base(person)
    {
        _discription = "with cleats";
        _speak = "With these spikey cleats, I can do anything!";
        _stats[1] += 3;
    }
}

public class BunDecorator : PersonNPCDecorator
{
    public BunDecorator(PeopleINPC person) : base(person)
    {
        _discription = "with a bun";
        _speak = "Is this a hat? *Puts bun on head* ";
        _stats[0] -= 3;
    }
}

public class MoneyDecorator : PersonNPCDecorator
{
    public MoneyDecorator(PeopleINPC person) : base(person)
    {
        _discription = "with money";
        _speak = "I got money! *Gets lazy* ";
        _stats[1] -= 3;
    }
}

public abstract class AnimalNPCDecorator : AnimalINPC
{
    AnimalINPC _animal;

    protected string _discription = "No additions";
    protected string _speak = "Nothing more";
    protected List<int> _stats;
    // Start is called before the first frame update
    public AnimalNPCDecorator(AnimalINPC animal)
    {
        _animal = animal;
        _stats = animal.GetStats();
    }

    public string Speak()
    {
        return string.Format("{0}, {1}", _animal.Speak(), _speak);
    }
    public string GetDescription()
    {
        return string.Format("{0}, {1}", _animal.GetDescription(), _discription);
    }

    public List<int> GetStats()
    {
        return _stats;
    }
}

public class SmartHelmetDecorator : AnimalNPCDecorator
{
    public SmartHelmetDecorator(AnimalINPC animal) : base(animal)
    {
        _discription = "with a Smart Helmet";
        _speak = "Am I smart?";
        _stats[0] += 3;
    }
}

public class BootiesDecorator : AnimalNPCDecorator
{
    public BootiesDecorator(AnimalINPC animal) : base(animal)
    {
        _discription = "with Booties";
        _speak = "*Can kick harder*";
        _stats[1] += 3;
    }
}

public class TreatDecorator : AnimalNPCDecorator
{
    public TreatDecorator(AnimalINPC animal) : base(animal)
    {
        _discription = "with a Treat";
        _speak = "I want the treat";
        _stats[0] -= 3;
    }
}

public class HeatedBlanketDecorator : AnimalNPCDecorator
{
    public HeatedBlanketDecorator(AnimalINPC animal) : base(animal)
    {
        _discription = "with a Heated Blanket";
        _speak = "This is nice *Gets lazy*";
        _stats[1] -= 3;
    }
}