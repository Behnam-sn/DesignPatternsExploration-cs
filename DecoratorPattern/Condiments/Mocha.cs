namespace DecoratorPattern;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        Beverage = beverage;
    }

    public override double Cost()
    {
        return Beverage.Cost() + .20;
    }

    public override string GetDescription()
    {
        return $"{Beverage.GetDescription()}, Mocha";
    }
}
