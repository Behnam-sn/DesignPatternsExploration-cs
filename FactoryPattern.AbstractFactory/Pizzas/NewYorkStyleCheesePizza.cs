namespace FactoryPattern.AbstractFactory;

public class NewYorkStyleCheesePizza : Pizza
{
    public NewYorkStyleCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "NY Style Sauce and Cheese Pizza";
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
    }
}