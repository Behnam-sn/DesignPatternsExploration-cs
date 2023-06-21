namespace FactoryPattern.AbstractFactory;

public abstract class PizzaStore
{
    public Pizza? OrderPizza(PizzaType type)
    {
        var pizza = createPizza(type);

        pizza?.Prepare();
        pizza?.Bake();
        pizza?.Cut();
        pizza?.Box();

        return pizza;
    }

    protected abstract Pizza? createPizza(PizzaType type);
}