namespace AdapterPattern;

public class TurkeyAdapter : Duck
{
    private readonly Turkey turkey;

    public TurkeyAdapter(Turkey turkey)
    {
        this.turkey = turkey;
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            turkey.Fly();
        }
    }

    public void Quack()
    {
        turkey.Gobble();
    }
}