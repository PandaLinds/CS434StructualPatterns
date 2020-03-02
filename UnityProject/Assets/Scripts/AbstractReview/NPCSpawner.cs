using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    private AbstractFactory factory;

    public void SpawnHorses()
    {
        AnimalINPC mHorse;
        AnimalINPC mHorseHelmet;
        AnimalINPC mHorseBooties;
        AnimalINPC mHorseTreat;
        AnimalINPC mHorseBlanket;
        factory = FactoryProducer.GetFactory(FactoryType.Animal);
    
        mHorse = factory.GetAnimal(AnimalNPCType.Horse);
        mHorseHelmet = new SmartHelmetDecorator(factory.GetAnimal(AnimalNPCType.Horse));
        mHorseBooties = new BootiesDecorator(factory.GetAnimal(AnimalNPCType.Horse));
        mHorseTreat = new TreatDecorator(factory.GetAnimal(AnimalNPCType.Horse));
        mHorseBlanket = new HeatedBlanketDecorator(factory.GetAnimal(AnimalNPCType.Horse));
        List<int> mHorsestats = mHorse.GetStats();
        List<int> mHorseHelmetstats = mHorseHelmet.GetStats();
        List<int> mHorseBootiesstats = mHorseBooties.GetStats();
        List<int> mHorseTreatstats = mHorseTreat.GetStats();
        List<int> mHorseBlanketsstats = mHorseBlanket.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mHorse.GetDescription() + " | Intel: " + mHorsestats[0] + " Strength: " + mHorsestats[1] + " | " + mHorse.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mHorseHelmet.GetDescription() + " | Intel: " + mHorseHelmetstats[0] + " Strength: " + mHorseHelmetstats[1] +" | " + mHorseHelmet.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mHorseBooties.GetDescription() + " | Intel: " + mHorseBootiesstats[0] + " Strength: " + mHorseBootiesstats[1] +" | " + mHorseBooties.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mHorseTreat.GetDescription() + " | Intel: " + mHorseTreatstats[0] + " Strength: " + mHorseTreatstats[1] +" | " + mHorseTreat.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mHorseBlanket.GetDescription() + " | Intel: " + mHorseBlanketsstats[0] + " Strength: " + mHorseBlanketsstats[1] +" | " + mHorseBlanket.Speak());
    }

    public void SpawnBull()
    {
        AnimalINPC mBull;
        AnimalINPC mBullHelmet;
        AnimalINPC mBullBooties;
        AnimalINPC mBullTreat;
        AnimalINPC mBullBlanket;
        factory = FactoryProducer.GetFactory(FactoryType.Animal);
    
        mBull = factory.GetAnimal(AnimalNPCType.Bull);
        mBullHelmet = new SmartHelmetDecorator(factory.GetAnimal(AnimalNPCType.Bull));
        mBullBooties = new BootiesDecorator(factory.GetAnimal(AnimalNPCType.Bull));
        mBullTreat = new TreatDecorator(factory.GetAnimal(AnimalNPCType.Bull));
        mBullBlanket = new HeatedBlanketDecorator(factory.GetAnimal(AnimalNPCType.Bull));
        List<int> mBullstats = mBull.GetStats();
        List<int> mBullHelmetstats = mBullHelmet.GetStats();
        List<int> mBullBootiesstats = mBullBooties.GetStats();
        List<int> mBullTreatstats = mBullTreat.GetStats();
        List<int> mBullBlanketsstats = mBullBlanket.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mBull.GetDescription() + " | Intel: " + mBullstats[0] + " Strength: " + mBullstats[1] + " | " + mBull.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mBullHelmet.GetDescription() + " | Intel: " + mBullHelmetstats[0] + " Strength: " + mBullHelmetstats[1] +" | " + mBullHelmet.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mBullBooties.GetDescription() + " | Intel: " + mBullBootiesstats[0] + " Strength: " + mBullBootiesstats[1] +" | " + mBullBooties.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mBullTreat.GetDescription() + " | Intel: " + mBullTreatstats[0] + " Strength: " + mBullTreatstats[1] +" | " + mBullTreat.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mBullBlanket.GetDescription() + " | Intel: " + mBullBlanketsstats[0] + " Strength: " + mBullBlanketsstats[1] +" | " + mBullBlanket.Speak());
    }

    public void SpawnDog()
    {
        AnimalINPC mDog;
        AnimalINPC mDogHelmet;
        AnimalINPC mDogBooties;
        AnimalINPC mDogTreat;
        AnimalINPC mDogBlanket;
        factory = FactoryProducer.GetFactory(FactoryType.Animal);
    
        mDog = factory.GetAnimal(AnimalNPCType.WienerDog);
        mDogHelmet = new SmartHelmetDecorator(factory.GetAnimal(AnimalNPCType.WienerDog));
        mDogBooties = new BootiesDecorator(factory.GetAnimal(AnimalNPCType.WienerDog));
        mDogTreat = new TreatDecorator(factory.GetAnimal(AnimalNPCType.WienerDog));
        mDogBlanket = new HeatedBlanketDecorator(factory.GetAnimal(AnimalNPCType.WienerDog));
        List<int> mDogstats = mDog.GetStats();
        List<int> mDogHelmetstats = mDogHelmet.GetStats();
        List<int> mDogBootiesstats = mDogBooties.GetStats();
        List<int> mDogTreatstats = mDogTreat.GetStats();
        List<int> mDogBlanketsstats = mDogBlanket.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mDog.GetDescription() + " | Intel: " + mDogstats[0] + " Strength: " + mDogstats[1] + " | " + mDog.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mDogHelmet.GetDescription() + " | Intel: " + mDogHelmetstats[0] + " Strength: " + mDogHelmetstats[1] +" | " + mDogHelmet.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mDogBooties.GetDescription() + " | Intel: " + mDogBootiesstats[0] + " Strength: " + mDogBootiesstats[1] +" | " + mDogBooties.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mDogTreat.GetDescription() + " | Intel: " + mDogTreatstats[0] + " Strength: " + mDogTreatstats[1] +" | " + mDogTreat.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mDogBlanket.GetDescription() + " | Intel: " + mDogBlanketsstats[0] + " Strength: " + mDogBlanketsstats[1] +" | " + mDogBlanket.Speak());
    }

    public void SpawnCowboys()
    {
        PeopleINPC mCowboy;
        PeopleINPC mCowboyNVG;
        PeopleINPC mCowboyBun;
        PeopleINPC mCowboyMoney;
        PeopleINPC mCowboyCleats;
        factory = FactoryProducer.GetFactory(FactoryType.People);
    
        mCowboy = factory.GetPeople(PeopleNPCType.Cowboy);
        mCowboyNVG = new NVGDecorator(factory.GetPeople(PeopleNPCType.Cowboy));
        mCowboyBun = new BunDecorator(factory.GetPeople(PeopleNPCType.Cowboy));
        mCowboyCleats = new CleatsDecorator(factory.GetPeople(PeopleNPCType.Cowboy));
        mCowboyMoney = new MoneyDecorator(factory.GetPeople(PeopleNPCType.Cowboy));
        
        List<int> mCowboystats = mCowboy.GetStats();
        List<int> mCowboyNVGstats = mCowboyNVG.GetStats();
        List<int> mCowboyBunstats = mCowboyBun.GetStats();
        List<int> mCowboyMoneystats = mCowboyMoney.GetStats();
        List<int> mCowboyCleatsstats = mCowboyCleats.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mCowboy.GetDescription() + " | Intel: " + mCowboystats[0] + " Strength: " + mCowboystats[1] + " | " + mCowboy.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCowboyNVG.GetDescription() + " | Intel: " + mCowboyNVGstats[0] + " Strength: " + mCowboyNVGstats[1] +" | " + mCowboyNVG.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCowboyBun.GetDescription() + " | Intel: " + mCowboyBunstats[0] + " Strength: " + mCowboyBunstats[1] +" | " + mCowboyBun.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCowboyCleats.GetDescription() + " | Intel: " + mCowboyCleatsstats[0] + " Strength: " + mCowboyCleatsstats[1] +" | " + mCowboyCleats.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCowboyMoney.GetDescription() + " | Intel: " + mCowboyMoneystats[0] + " Strength: " + mCowboyMoneystats[1] +" | " + mCowboyMoney.Speak());
    }

    public void SpawnCityboys()
    {

        PeopleINPC mCityboy;
        PeopleINPC mCityboyNVG;
        PeopleINPC mCityboyBun;
        PeopleINPC mCityboyMoney;
        PeopleINPC mCityboyCleats;
        factory = FactoryProducer.GetFactory(FactoryType.People);

        mCityboy = factory.GetPeople(PeopleNPCType.Cityboy);
        mCityboyNVG = new NVGDecorator(factory.GetPeople(PeopleNPCType.Cityboy));
        mCityboyBun = new BunDecorator(factory.GetPeople(PeopleNPCType.Cityboy));
        mCityboyCleats = new CleatsDecorator(factory.GetPeople(PeopleNPCType.Cityboy));
        mCityboyMoney = new MoneyDecorator(factory.GetPeople(PeopleNPCType.Cityboy));
        
        List<int> mCityboystats = mCityboy.GetStats();
        List<int> mCityboyNVGstats = mCityboyNVG.GetStats();
        List<int> mCityboyBunstats = mCityboyBun.GetStats();
        List<int> mCityboyMoneystats = mCityboyMoney.GetStats();
        List<int> mCityboyCleatsstats = mCityboyCleats.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mCityboy.GetDescription() + " | Intel: " + mCityboystats[0] + " Strength: " + mCityboystats[1] + " | " + mCityboy.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCityboyNVG.GetDescription() + " | Intel: " + mCityboyNVGstats[0] + " Strength: " + mCityboyNVGstats[1] +" | " + mCityboyNVG.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCityboyBun.GetDescription() + " | Intel: " + mCityboyBunstats[0] + " Strength: " + mCityboyBunstats[1] +" | " + mCityboyBun.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCityboyCleats.GetDescription() + " | Intel: " + mCityboyCleatsstats[0] + " Strength: " + mCityboyCleatsstats[1] +" | " + mCityboyCleats.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mCityboyMoney.GetDescription() + " | Intel: " + mCityboyMoneystats[0] + " Strength: " + mCityboyMoneystats[1] +" | " + mCityboyMoney.Speak());
    }

    public void SpawnWeenies()
    {
        PeopleINPC mWeenie;
        PeopleINPC mWeenieNVG;
        PeopleINPC mWeenieBun;
        PeopleINPC mWeenieMoney;
        PeopleINPC mWeenieCleats;
        factory = FactoryProducer.GetFactory(FactoryType.People);

        mWeenie = factory.GetPeople(PeopleNPCType.Weenie);
        mWeenieNVG = new NVGDecorator(factory.GetPeople(PeopleNPCType.Weenie));
        mWeenieBun = new BunDecorator(factory.GetPeople(PeopleNPCType.Weenie));
        mWeenieCleats = new CleatsDecorator(factory.GetPeople(PeopleNPCType.Weenie));
        mWeenieMoney = new MoneyDecorator(factory.GetPeople(PeopleNPCType.Weenie));
        
        List<int> mWeeniestats = mWeenie.GetStats();
        List<int> mWeenieNVGstats = mWeenieNVG.GetStats();
        List<int> mWeenieBunstats = mWeenieBun.GetStats();
        List<int> mWeenieMoneystats = mWeenieMoney.GetStats();
        List<int> mWeenieCleatsstats = mWeenieCleats.GetStats();
        Debug.Log("Person Discription, Stats, and Speech: " + mWeenie.GetDescription() + " | Intel: " + mWeeniestats[0] + " Strength: " + mWeeniestats[1] + " | " + mWeenie.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mWeenieNVG.GetDescription() + " | Intel: " + mWeenieNVGstats[0] + " Strength: " + mWeenieNVGstats[1] +" | " + mWeenieNVG.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mWeenieBun.GetDescription() + " | Intel: " + mWeenieBunstats[0] + " Strength: " + mWeenieBunstats[1] +" | " + mWeenieBun.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mWeenieCleats.GetDescription() + " | Intel: " + mWeenieCleatsstats[0] + " Strength: " + mWeenieCleatsstats[1] +" | " + mWeenieCleats.Speak());
        Debug.Log("Person Discription, Stats, and Speech: " + mWeenieMoney.GetDescription() + " | Intel: " + mWeenieMoneystats[0] + " Strength: " + mWeenieMoneystats[1] +" | " + mWeenieMoney.Speak());
    }
}
