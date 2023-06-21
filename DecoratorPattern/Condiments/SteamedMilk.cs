namespace DecoratorPattern;

public class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .10;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Steamed Milk";
    }
}
