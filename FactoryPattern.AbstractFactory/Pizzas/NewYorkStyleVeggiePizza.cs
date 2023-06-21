namespace FactoryPattern.AbstractFactory;

public class NewYorkStyleVeggiePizza : Pizza
{
    public NewYorkStyleVeggiePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "NewYork Style Veggie Pizza";
    }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}