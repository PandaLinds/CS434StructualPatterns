using UnityEngine;

public interface INPC
{
    void Speak();
}

public class Beggar : INPC
{
    public void Speak()
    {
        Debug.Log("Do you have some change to spare?");
    }
}

public class Shopowner : INPC
{
    public void Speak()
    {
        Debug.Log("I have wears if you have coin.");
    }
}

public class Farmer : INPC
{
    public void Speak()
    {
        Debug.Log("It's not a lot, but it's honest work");
    }
}