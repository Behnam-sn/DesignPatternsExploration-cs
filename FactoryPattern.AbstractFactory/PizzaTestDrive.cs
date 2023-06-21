using FactoryPattern.AbstractFactory;

PizzaStore newyorkStore = new NewYorkPizzaStore();
PizzaStore chicagoStore = new ChicagoPizzaStore();

Pizza? pizza = newyorkStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine("Ethan ordered a " + pizza?.Name);
Console.WriteLine();

pizza = chicagoStore.OrderPizza(PizzaType.Cheese);
Console.WriteLine("Joel ordered a " + pizza?.Name);
Console.WriteLine();