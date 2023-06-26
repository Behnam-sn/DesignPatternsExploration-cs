using AdapterPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var turkey = new WildTurkey();
        var duck = new MallardDuck();
        var turkeyAdapter = new TurkeyAdapter(turkey);
        var duckAdapter = new DuckAdapter(duck);

        Console.WriteLine("The Turkey says...");
        testTurkey(turkey);

        Console.WriteLine("\nThe Duck says...");
        testDuck(duck);

        Console.WriteLine("\nThe DuckAdapter says...");
        testTurkey(duckAdapter);

        Console.WriteLine("\nThe TurkeyAdapter says...");
        testDuck(turkeyAdapter);
    }

    private static void testTurkey(Turkey turkey)
    {
        turkey.Gobble();
        turkey.Fly();
    }

    private static void testDuck(Duck duck)
    {
        duck.Quack();
        duck.Fly();
    }
}