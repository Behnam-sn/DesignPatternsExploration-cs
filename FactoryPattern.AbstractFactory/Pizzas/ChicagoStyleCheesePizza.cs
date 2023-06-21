namespace FactoryPattern.AbstractFactory;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza(PizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
        Clam = ingredientFactory.CreateClam();
    }
}