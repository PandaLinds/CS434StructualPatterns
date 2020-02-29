using UnityEngine;

public interface PeopleINPC
{
    string Speak();
    string GetDescription();
}

// public class Cityboy : PeopleINPC
// {
//     public void Speak()
//     {
//         Debug.Log("I'm from the city");
//     }
// }

public class Cowboy : PeopleINPC
{
    public string Speak()
    {
        return "Howdy";
    }
    public string GetDescription()
    {
        return "Cowboy";
    }
}

// public class Weenie : PeopleINPC
// {
//     public void Speak()
//     {
//         Debug.Log("Don't hurt me");
//     }
// }