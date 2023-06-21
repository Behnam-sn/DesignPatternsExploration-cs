namespace FactoryPattern.AbstractFactory;

public class CaliforniaStylePepperoniPizza : Pizza
{
    public CaliforniaStylePepperoniPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "California Style Pepperoni Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}