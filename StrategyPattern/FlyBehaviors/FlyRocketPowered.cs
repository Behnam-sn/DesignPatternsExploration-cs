namespace StrategyPattern;

internal class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        System.Console.WriteLine("I'm flying with a rocket!");
    }
}