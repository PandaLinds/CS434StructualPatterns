using UnityEngine;

public class PeopleNPCFactory : AbstractFactory
{
    public override PeopleINPC GetPeople(PeopleNPCType peopleType)
    {
        switch (peopleType)
        {
            case PeopleNPCType.Cityboy:
                PeopleINPC cityboy = new Cityboy();
                return cityboy;
            case PeopleNPCType.Cowboy:
                PeopleINPC cowboy = new Cowboy();
                return cowboy;
            case PeopleNPCType.Weenie:
                PeopleINPC weenie = new Weenie();
                return weenie;
        }
        return null;
    }

    public override AnimalINPC GetAnimal(AnimalNPCType animalType)
    {
        return null;
    }
}
