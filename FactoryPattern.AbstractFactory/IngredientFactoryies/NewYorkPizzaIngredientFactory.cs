namespace FactoryPattern.AbstractFactory;

public class NewYorkPizzaIngredientFactory : PizzaIngredientFactory
{
    public Cheese CreateCheese()
    {
        return new ReggianoCheese();
    }

    public Clam CreateClam()
    {
        return new FreshClams();
    }

    public Dough CreateDough()
    {
        return new ThinCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new MarinaraSauce();
    }

    public List<Veggies> CreateVeggies()
    {
        return new List<Veggies>() { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }
}