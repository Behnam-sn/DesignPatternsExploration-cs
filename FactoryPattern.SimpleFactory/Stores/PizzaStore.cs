namespace FactoryPattern.SimpleFactory;

public class PizzaStore
{
    private SimplePizzaFactory factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        this.factory = factory;
    }

    public Pizza? OrderPizza(PizzaType type)
    {
        var pizza = factory.CreatePizza(type);

        pizza?.Prepare();
        pizza?.Bake();
        pizza?.Cut();
        pizza?.Box();

        return pizza;
    }
}