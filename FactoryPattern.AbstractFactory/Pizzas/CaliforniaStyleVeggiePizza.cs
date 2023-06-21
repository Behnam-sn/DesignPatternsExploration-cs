namespace FactoryPattern.AbstractFactory;

public class CaliforniaStyleVeggiePizza : Pizza
{
    public CaliforniaStyleVeggiePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "California Style Veggie Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}