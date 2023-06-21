namespace FactoryPattern.FactoryMethod;

public class NewYorkPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        if (type == PizzaType.Cheese)
        {
            return new NewYorkStyleCheesePizza();
        }

        if (type == PizzaType.Veggie)
        {
            return new NewYorkStyleVeggiePizza();
        }

        if (type == PizzaType.Clam)
        {
            return new NewYorkStyleClamPizza();
        }

        if (type == PizzaType.Pepperoni)
        {
            return new NewYorkStylePepperoniPizza();
        }

        return null;
    }
}