namespace FactoryPattern.FactoryMethod;

public class CaliforniaPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        if (type == PizzaType.Cheese)
        {
            return new CaliforniaStyleCheesePizza();
        }

        if (type == PizzaType.Veggie)
        {
            return new CaliforniaStyleVeggiePizza();
        }

        if (type == PizzaType.Clam)
        {
            return new CaliforniaStyleClamPizza();
        }

        if (type == PizzaType.Pepperoni)
        {
            return new CaliforniaStylePepperoniPizza();
        }

        return null;
    }
}
