namespace FactoryPattern.AbstractFactory;

public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
{
    public Cheese CreateCheese()
    {
        return new MozzarellaCheese();
    }

    public Clam CreateClam()
    {
        return new FrozenClams();
    }

    public Dough CreateDough()
    {
        return new ThickCrustDough();
    }

    public Pepperoni CreatePepperoni()
    {
        return new SlicedPepperoni();
    }

    public Sauce CreateSauce()
    {
        return new PlumTomatoSauce();
    }

    public List<Veggies> CreateVeggies()
    {
        return new List<Veggies> { new BlackOlives(), new Spinach(), new EggPlant() };
    }
}