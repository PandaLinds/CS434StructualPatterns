public class Espresso : ICoffee
{
    public string GetDescription()
    {
        return "Espresso made with care";
    }
 
    public double GetCost()
    {
        return 2.99;
    }
}