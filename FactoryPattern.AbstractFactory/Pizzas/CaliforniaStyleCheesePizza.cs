namespace FactoryPattern.AbstractFactory;

public class CaliforniaStyleCheesePizza : Pizza
{
    public CaliforniaStyleCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "California Style Cheese Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}