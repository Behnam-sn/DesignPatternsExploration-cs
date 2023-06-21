namespace StrategyPattern;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;

    public Duck()
    {
        this.flyBehavior = new FlyNoWay();
        this.quackBehavior = new MuteQuack();
    }

    public abstract void Display();

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        System.Console.WriteLine("All ducks float, even decoys!");
    }

    public void SetFlyBehavior(IFlyBehavior fb)
    {
        flyBehavior = fb;
    }

    public void SetQuackBehavior(IQuackBehavior qb)
    {
        quackBehavior = qb;
    }
}