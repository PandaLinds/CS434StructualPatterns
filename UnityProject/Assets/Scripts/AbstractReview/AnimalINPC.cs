using UnityEngine;

public interface AnimalINPC
{
    void Speak();
    string GetDescription();
}

public class Horse : AnimalINPC
{
    public void Speak()
    {
        Debug.Log("Gotta ride into the sunset");
    }
    public string GetDescription()
    {
        return "Horse";
    }
}

// public class Bull : AnimalINPC
// {
//     public void Speak()
//     {
//         Debug.Log("I don't like red");
//     }
// }

// public class WienerDog : AnimalINPC
// {
//     public void Speak()
//     {
//         Debug.Log("Where's the snacks");
//     }
// }