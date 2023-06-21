namespace FactoryPattern.AbstractFactory;

public class CaliforniaPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        var ingredientFactory = new CaliforniaPizzaIngredientFactory();

        if (type == PizzaType.Cheese)
        {
            return new CaliforniaStyleCheesePizza(ingredientFactory);
        }

        if (type == PizzaType.Veggie)
        {
            return new CaliforniaStyleVeggiePizza(ingredientFactory);
        }

        if (type == PizzaType.Clam)
        {
            return new CaliforniaStyleClamPizza(ingredientFactory);
        }

        if (type == PizzaType.Pepperoni)
        {
            return new CaliforniaStylePepperoniPizza(ingredientFactory);
        }

        return null;
    }
}