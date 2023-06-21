namespace FactoryPattern.AbstractFactory;

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "Chicago Style Veggie Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}