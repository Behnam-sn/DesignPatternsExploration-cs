namespace DecoratorPattern;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .10;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Whip";
    }
}
