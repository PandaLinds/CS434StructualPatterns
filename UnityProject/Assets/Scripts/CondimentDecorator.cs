public abstract class CondimentDecorator : ICoffee
{
    ICoffee _coffee;
 
    protected string _name = "undefined condiment";
    protected double _price = 0.0;
 
    public CondimentDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }
 
    public string GetDescription()
    {
        return string.Format("{0}, {1}", _coffee.GetDescription(), _name);
    }
 
    public double GetCost()
    {
        return _coffee.GetCost() + _price;
    }
}

public class MilkDecorator : CondimentDecorator
{
    public MilkDecorator(ICoffee coffee)
        :base(coffee)
    {
        _name = "Milk";
        _price = 0.19;
    }
}
 
public class ChocolateDecorator : CondimentDecorator
{
    public ChocolateDecorator(ICoffee coffee)
        :base(coffee)
    {
        _name = "Chocolate";
        _price = 0.29;
    }
}