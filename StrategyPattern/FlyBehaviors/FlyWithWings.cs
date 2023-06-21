namespace StrategyPattern;

internal class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        System.Console.WriteLine("I'm flying!!");
    }
}