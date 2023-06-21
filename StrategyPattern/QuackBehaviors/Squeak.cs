namespace StrategyPattern;

internal class Squeak : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("Squeak");
    }
}