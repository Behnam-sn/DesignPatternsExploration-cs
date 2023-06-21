using FactoryPattern.SimpleFactory;

PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());

Pizza? pizza = pizzaStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine("Ethan ordered a " + pizza?.Name);
Console.WriteLine();

pizza = pizzaStore.OrderPizza(PizzaType.Pepperoni);
Console.WriteLine("Joel ordered a " + pizza?.Name);
Console.WriteLine();