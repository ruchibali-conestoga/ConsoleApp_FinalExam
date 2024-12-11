using ConsoleApp_FinalExam.ConcreteClass;
using ConsoleApp_FinalExam;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Warehouse Management System");
        Console.WriteLine("3. Add Product");
        Console.WriteLine("5. Edit Product");
        Console.WriteLine("1. List All Products");
        Console.WriteLine("2. View Specific Product");
        Console.WriteLine("4. Remove Product");
        Console.WriteLine("6. Adjust Stock");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an option: ");

        Warehouse warehouse = new Warehouse();

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

        // List all products
        var products = warehouse.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine(product.GetProductDetails());
        }

        // Adjust stock
        warehouse.AdjustStock(1, -20);

        // View a specific product
        var productDetails = warehouse.GetProduct(1);
        Console.WriteLine(productDetails?.GetProductDetails());

        // Remove a product
        warehouse.RemoveProduct(2);
    }



}

