namespace FactoryPattern.AbstractFactory;

public class NewYorkStylePepperoniPizza : Pizza
{
    public NewYorkStylePepperoniPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "NewYork Style Pepperoni Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}