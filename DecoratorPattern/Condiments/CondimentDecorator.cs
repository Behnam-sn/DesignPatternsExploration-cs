namespace DecoratorPattern;

public abstract class CondimentDecorator : Beverage
{
    public Beverage Beverage = null!;
    public override abstract string GetDescription();
}
