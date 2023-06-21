namespace FactoryPattern.AbstractFactory;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        var ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (type == PizzaType.Cheese)
        {
            return new ChicagoStyleCheesePizza(ingredientFactory);
        }

        if (type == PizzaType.Veggie)
        {
            return new ChicagoStyleVeggiePizza(ingredientFactory);
        }

        if (type == PizzaType.Clam)
        {
            return new ChicagoStyleClamPizza(ingredientFactory);
        }

        if (type == PizzaType.Pepperoni)
        {
            return new ChicagoStylePepperoniPizza(ingredientFactory);
        }

        return null;
    }
}