namespace DecoratorPattern;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .15;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Soy";
    }
}
