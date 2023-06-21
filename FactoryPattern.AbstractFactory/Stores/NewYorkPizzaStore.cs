namespace FactoryPattern.AbstractFactory;

public class NewYorkPizzaStore : PizzaStore
{
    protected override Pizza? createPizza(PizzaType type)
    {
        var ingredientFactory = new NewYorkPizzaIngredientFactory();

        if (type == PizzaType.Cheese)
        {
            return new NewYorkStyleCheesePizza(ingredientFactory);
        }

        if (type == PizzaType.Veggie)
        {
            return new NewYorkStyleVeggiePizza(ingredientFactory);
        }

        if (type == PizzaType.Clam)
        {
            return new NewYorkStyleClamPizza(ingredientFactory);
        }

        if (type == PizzaType.Pepperoni)
        {
            return new NewYorkStylePepperoniPizza(ingredientFactory);
        }

        return null;
    }
}