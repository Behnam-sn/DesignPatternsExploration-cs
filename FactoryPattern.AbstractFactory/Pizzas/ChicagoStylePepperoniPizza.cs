namespace FactoryPattern.AbstractFactory;

public class ChicagoStylePepperoniPizza : Pizza
{
    public ChicagoStylePepperoniPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "Chicago Style Pepperoni Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}