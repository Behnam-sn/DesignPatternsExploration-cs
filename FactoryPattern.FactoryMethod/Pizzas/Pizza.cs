namespace FactoryPattern.FactoryMethod;

public abstract class Pizza
{
    public string Name { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public List<string> Toppings { get; set; }

    protected Pizza()
    {
        Name = string.Empty;
        Dough = string.Empty;
        Sauce = string.Empty;
        Toppings = new();
    }

    public void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding sauce...");
        Console.WriteLine("Adding toppings: ");
        foreach (var topping in Toppings)
        {
            Console.WriteLine(" " + topping);
        }
    }

    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
}