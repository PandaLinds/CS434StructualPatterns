using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PersonNPCDecorator : PeopleINPC
{
    PeopleINPC _person;

    protected string _discription = "No additions";
    protected string _speak = "Nothing more";
    // Start is called before the first frame update
    public PersonNPCDecorator(PeopleINPC person)
    {
        _person = person;
    }

    public string Speak()
    {
        return string.Format("{0}, {1}", _person.Speak(), _speak);
    }
    public string GetDescription()
    {
        return string.Format("{0}, {1}", _person.GetDescription(), _discription);
    }
}

public class NVGDecorator : PersonNPCDecorator
{
    public NVGDecorator(PeopleINPC person) : base(person)
    {
        _discription = "with NVGs";
        _speak = "Now I can ride in the night";
    }
}