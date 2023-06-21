namespace FactoryPattern.FactoryMethod;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        if (type == PizzaType.Cheese)
        {
            return new ChicagoStyleCheesePizza();
        }

        if (type == PizzaType.Veggie)
        {
            return new ChicagoStyleVeggiePizza();
        }

        if (type == PizzaType.Clam)
        {
            return new ChicagoStyleClamPizza();
        }

        if (type == PizzaType.Pepperoni)
        {
            return new ChicagoStylePepperoniPizza();
        }

        return null;
    }
}
