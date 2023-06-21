namespace StrategyPattern;

internal class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        System.Console.WriteLine("<< Silence >>");
    }
}