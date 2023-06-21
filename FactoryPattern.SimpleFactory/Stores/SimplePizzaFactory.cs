namespace FactoryPattern.SimpleFactory;

public class SimplePizzaFactory
{
    public Pizza? CreatePizza(PizzaType type)
    {
        Pizza? pizza = null;

        if (type == PizzaType.Cheese)
        {
            pizza = new CheesePizza();
        }
        else if (type == PizzaType.Greek)
        {
            pizza = new GreekPizza();
        }
        else if (type == PizzaType.Pepperoni)
        {
            pizza = new PepperoniPizza();
        }
        else if (type == PizzaType.Clam)
        {
            pizza = new ClamPizza();
        }
        else if (type == PizzaType.Veggie)
        {
            pizza = new VeggiePizza();
        }

        return pizza;
    }
}