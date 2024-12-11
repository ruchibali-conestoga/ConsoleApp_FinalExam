using ConsoleApp_FinalExam.ConcreteClass;
using ConsoleApp_FinalExam;

//Console.WriteLine("Hello, World!");
Console.WriteLine("Warehouse Management System");
Console.WriteLine("1. Add Product");
Console.WriteLine("2. List All Products");
Console.WriteLine("3. View Specific Product");
Console.WriteLine("4. Edit Product");
Console.WriteLine("5. Remove Product");
Console.WriteLine("6. Adjust Stock");
Console.WriteLine("7. Exit");
Console.Write("Choose an option: ");
int userChoice = int.Parse(Console.ReadLine());

Warehouse warehouse = new Warehouse();

if (userChoice == 0)
{
    Console.WriteLine("Please enter correct option!");
}
else if (userChoice == 1)
{

    // Adding products
    ProduceProduct apple = new ProduceProduct
    {
        ID = 1,
        Name = "Apple",
        Source = "In-house",
        Type = "Fruit",
        Quantity = 100
    };

    ProduceProduct rice = new ProduceProduct
    {
        ID = 2,
        Name = "Rice",
        Source = "3rd Party",
        Type = "Grain",
        Quantity = 200
    };

    warehouse.AddProduct(apple);
    warehouse.AddProduct(rice);
}
else if (userChoice == 2)
{
    // List all products
    var products = warehouse.GetAllProducts();
    foreach (var product in products)
    {
        Console.WriteLine(product.GetProductDetails());
    }
}
else if (userChoice == 3)
{
    // View a specific product
    var productDetails = warehouse.GetProduct(1);
    Console.WriteLine(productDetails?.GetProductDetails());
}
else if (userChoice == 4)
{
    // edit a product
    // warehouse.RemoveProduct(2);
}
else if (userChoice == 5)
{
    // Remove a product
    warehouse.RemoveProduct(2);
}
else if (userChoice == 6)
{
    // Adjust stock
    warehouse.AdjustStock(1, -20);
}
else if (userChoice == 7)
{ }
else
{ Console.WriteLine("Please enter correct option!"); }
