namespace DecoratorPattern;

public abstract class Beverage
{
    public string Description = "Unknown Beverage";

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}
