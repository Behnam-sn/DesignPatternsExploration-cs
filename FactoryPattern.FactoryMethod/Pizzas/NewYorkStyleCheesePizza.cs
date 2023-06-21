namespace FactoryPattern.FactoryMethod;

public class NewYorkStyleCheesePizza : Pizza
{
    public NewYorkStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggia no Cheese");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
}