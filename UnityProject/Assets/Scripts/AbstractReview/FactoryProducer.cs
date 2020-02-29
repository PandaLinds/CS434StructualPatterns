using UnityEngine;

public class FactoryProducer : MonoBehaviour
{
    public static AbstractFactory GetFactory(FactoryType factoryType)
    {
        switch (factoryType)
        {
            case FactoryType.People:
                AbstractFactory humanFactory = new PeopleNPCFactory();
                return humanFactory;
            case FactoryType.Animal:
                AbstractFactory animalFactory = new AnimalNPCFactory();
                return animalFactory;
        }
            return null;
    }
}