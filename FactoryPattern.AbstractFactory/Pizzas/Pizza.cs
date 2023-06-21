namespace FactoryPattern.AbstractFactory;

public abstract class Pizza
{
    public string? Name { get; set; }
    public Dough? Dough { get; set; }
    public Sauce? Sauce { get; set; }
    public Cheese? Cheese { get; set; }
    public Pepperoni? Pepperoni { get; set; }
    public Clam? Clam { get; set; }
    public List<string>? Toppings { get; set; }
    public List<Veggies>? Veggies { get; set; }

    protected PizzaIngredientFactory ingredientFactory;

    protected Pizza(PizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
    }

    public abstract void Prepare();

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