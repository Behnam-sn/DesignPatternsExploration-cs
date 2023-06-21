namespace FactoryPattern.AbstractFactory;

public interface PizzaIngredientFactory
{
    public Dough CreateDough();

    public Sauce CreateSauce();

    public Cheese CreateCheese();

    public List<Veggies> CreateVeggies();

    public Pepperoni CreatePepperoni();

    public Clam CreateClam();
}