namespace AdapterPattern;

public class DuckAdapter : Turkey
{
    private readonly Duck duck;
    private readonly Random rand;

    public DuckAdapter(Duck duck)
    {
        this.duck = duck;
        rand = new Random();
    }

    public void Fly()
    {
        if (rand.NextInt64(5) == 0)
        {
            duck.Fly();
        }
    }

    public void Gobble()
    {
        duck.Quack();
    }
}