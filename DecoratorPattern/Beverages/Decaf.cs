namespace DecoratorPattern;

public class Decaf : Beverage
{
    public Decaf()
    {
        Description = "Decaf Coffee";
    }

    public override double Cost()
    {
        throw new NotImplementedException();
    }
}