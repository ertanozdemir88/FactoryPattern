using FactoryPattern;

Console.WriteLine("Enter the type of pizza you want to order: (Sucuklu, Margherita, Pepperoni, Veggie)");
string pizzaType = Console.ReadLine();

try
{
    Pizza pizza = PizzaFactory.CreatePizza(pizzaType);
    pizza.Prepare();
    pizza.Bake();
    pizza.Cut();
    pizza.Box();

    Console.WriteLine($"{pizzaType} Pizza is ready to be served!");

}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.ReadLine();