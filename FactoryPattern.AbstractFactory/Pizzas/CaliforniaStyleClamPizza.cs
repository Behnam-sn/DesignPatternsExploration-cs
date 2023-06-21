namespace FactoryPattern.AbstractFactory;

public class CaliforniaStyleClamPizza : Pizza
{
    public CaliforniaStyleClamPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "California Style Clam Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}