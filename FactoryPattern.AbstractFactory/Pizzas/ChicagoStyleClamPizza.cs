namespace FactoryPattern.AbstractFactory;

public class ChicagoStyleClamPizza : Pizza
{
    public ChicagoStyleClamPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "Chicago Style Clam Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}