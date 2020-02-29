using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    private AnimalINPC mHorse;
    // private AnimalINPC mBull;
    // private AnimalINPC mWienerDog;

    // private PeopleINPC mCityboy;
    private PeopleINPC mCowboy;
    private PeopleINPC mCowboyNVG;
    // private PeopleINPC mWeenie;

    private AbstractFactory factory;

    public void SpawnAnimals()
    {
        factory = FactoryProducer.GetFactory(FactoryType.Animal);

        mHorse = factory.GetAnimal(AnimalNPCType.Horse);
        // mBull = factory.GetAnimal(AnimalNPCType.Bull);
        // mWienerDog = factory.GetAnimal(AnimalNPCType.WienerDog);

        mHorse.Speak();
        // mBull.Speak();
        // mWienerDog.Speak();
    }

    public void SpawnPeople()
    {
        factory = FactoryProducer.GetFactory(FactoryType.People);

        // mCityboy = factory.GetPeople(PeopleNPCType.Cityboy);
        mCowboy = factory.GetPeople(PeopleNPCType.Cowboy);
        mCowboyNVG = new NVGDecorator(factory.GetPeople(PeopleNPCType.Cowboy));
        // mWeenie = factory.GetPeople(PeopleNPCType.Weenie);

        // mCityboy.Speak();
        Debug.Log("Person discription and Speech: " + mCowboy.GetDescription() + " | " + mCowboy.Speak());
        Debug.Log("Person discription and Speech: " + mCowboyNVG.GetDescription() + " | " + mCowboyNVG.Speak());
        
        // mWeenie.Speak();
    }
}
