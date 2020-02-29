
public abstract class AbstractFactory
{
    public abstract PeopleINPC GetPeople(PeopleNPCType humanType);
    public abstract AnimalINPC GetAnimal(AnimalNPCType animalType);
}

