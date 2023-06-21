namespace FactoryPattern.AbstractFactory;

public class NewYorkStyleClamPizza : Pizza
{
    public NewYorkStyleClamPizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "NewYork Style Clam Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}