using UnityEngine;

public class AnimalNPCFactory : AbstractFactory
{
    public override AnimalINPC GetAnimal(AnimalNPCType animalType)
    {
        switch (animalType)
        {
            case AnimalNPCType.Horse:
                AnimalINPC horse = new Horse();
                return horse;
            // case AnimalNPCType.Bull:
            //     AnimalINPC bull = new Bull();
            //     return bull;
            // case AnimalNPCType.WienerDog:
            //     AnimalINPC wienerDog = new WienerDog();
            //     return wienerDog;
        }
        return null;
    }

    public override PeopleINPC GetPeople(PeopleNPCType humanType)
    {
        return null;
    }
}
