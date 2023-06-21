namespace StrategyPattern;

internal class Quack : IQuackBehavior
{
    void IQuackBehavior.Quack()
    {
        System.Console.WriteLine("Quack");
    }
}