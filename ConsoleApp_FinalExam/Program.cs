using ConsoleApp_FinalExam.ConcreteClass;
using ConsoleApp_FinalExam;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        #region Task 3: Add/Edit/Delete/Update/GetAll/GetParticular
        Console.WriteLine("----- Task 3:Add/Edit/Delete/Update/GetAll/GetParticular Product  -----");
        Warehouse warehouse2 = new Warehouse();

        //AddProduct
        #region Add Product
        Console.Write("Enter Product Name: ");
        string nameOfProduct = Console.ReadLine();
        Console.Write("Enter Source (In-house/3rd Party): ");
        string sourceName = Console.ReadLine();
        Console.Write("Enter Type (e.g., Fruit, Grain): ");
        string typeName = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity_Number))
        {
            Console.WriteLine("Invalid quantity. Operation cancelled.");
            return;
        }

        ProduceProduct newProduct2 = new ProduceProduct
        {
            ID = warehouse2.GetAllProducts().Count + 1,
            Name = nameOfProduct,
            Source = sourceName,
            Type = typeName,
            Quantity = quantity_Number
        };

        warehouse2.AddProduct(newProduct2);
        //Console.WriteLine("Product added successfully!");
        #endregion

        //GetAllProduct
        #region GetAllProduct
        Console.WriteLine("-----All Added Product Details-----");
        var products_all = warehouse2.GetAllProducts();
        if (products_all.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            foreach (var product1 in products_all)
            {
                Console.WriteLine(product1.GetProductDetails());
            }
        }
        #endregion

        //View Particular Product
        # region View Particular Product
        Console.WriteLine("-----View Particular Product Details-----");
        Console.Write("Enter Product ID: ");
        if (!int.TryParse(Console.ReadLine(), out int productId))
        {
            Console.WriteLine("Invalid ID. Operation cancelled.");
            return;
        }

        var product = warehouse2.GetProduct(productId);
        if (product == null)
        {
            Console.WriteLine("Product not found.");
        }
        else
        {
            Console.WriteLine(product.GetProductDetails());
        }
        #endregion

        //Update Particular Product
        #region Update Particular Product
        Console.WriteLine("-----View Particular Product Details and Edit -----");
        Console.Write("Enter Product ID to Edit: ");
        if (!int.TryParse(Console.ReadLine(), out int productId_edit))
        {
            Console.WriteLine("Invalid ID. Operation cancelled.");
            return;
        }

        var product_edit = warehouse2.GetProduct(productId);
        if (product_edit == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("Enter New Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter New (In-house/3rd Party): ");
        string source = Console.ReadLine();
        Console.Write("Enter New Type (e.g., Fruit, Grain): ");
        string type = Console.ReadLine();
        Console.Write("Enter New Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity))
        {
            Console.WriteLine("Invalid quantity. Operation cancelled.");
            return;
        }

        product.Name = string.IsNullOrWhiteSpace(name) ? product.Name : name;
        product.Source = string.IsNullOrWhiteSpace(source) ? product.Source : source;
        //product.Type = string.IsNullOrWhiteSpace(type) ? product.Type : type;
        product.Quantity = quantity;

        Console.WriteLine("Product updated successfully!");
        #endregion

        //GetAllProduct
        #region GetAllProduct
        Console.WriteLine("-----All Added Product Details-----");
        var products_all1 = warehouse2.GetAllProducts();
        if (products_all.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            foreach (var product2 in products_all1)
            {
                Console.WriteLine(product2.GetProductDetails());
            }
        }
        #endregion

        //Delete Product
        #region Delete Product
        Console.WriteLine("----- View Particular Product Details and Delete -----");
        Console.Write("Enter Product ID to Remove: ");
        
        if (!int.TryParse(Console.ReadLine(), out int productId_del))
        {
            Console.WriteLine("Invalid ID. Operation cancelled.");
            return;
        }
        var product_del = warehouse2.GetProduct(productId);
        if (product_del == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }
        else
        {
            warehouse2.RemoveProduct(productId_del);
           // Console.WriteLine("Product removed successfully!");
        }
        #endregion

        //GetAllProduct
        #region GetAllProduct
        Console.WriteLine("-----All Added Product Details-----");
        var products_all3 = warehouse2.GetAllProducts();
        if (products_all.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            foreach (var product3 in products_all3)
            {
                Console.WriteLine(product3.GetProductDetails());
            }
        }
        #endregion

        #endregion

        #region Task1: GetAllProducts and current Status

        //GetAllProduct
        #region GetAllProduct
        Console.WriteLine("----- Task 1:GetAllProduct and Current Status -----");
        Console.WriteLine("----- All Added Product Details-----");
        var products_all_task1 = warehouse2.GetAllProducts();
        if (products_all_task1.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            foreach (var product_all_task1 in products_all_task1)
            {
                Console.WriteLine(product_all_task1.GetProductDetails());
            }
        }
        #endregion
        #endregion

        #region Task2: Get Products Details but for one specific product

        # region View Particular Product
        Console.WriteLine("-----View Particular Product Details-----");
        Console.Write("Enter Product ID: ");
        if (!int.TryParse(Console.ReadLine(), out int productId_task))
        {
            Console.WriteLine("Invalid ID. Operation cancelled.");
            return;
        }

        var product_task = warehouse2.GetProduct(productId_task);
        if (product_task == null)
        {
            Console.WriteLine("Product not found.");
        }
        else
        {
            Console.WriteLine(product_task.GetProductDetails());
        }
        #endregion

        #endregion

        #region Task4:  to manipulate the stock (amount of products you have)
        //GetAllProduct
        #region GetAllProduct
        Console.WriteLine("-----All Added Product Details-----");
        var products_all_Task = warehouse2.GetAllProducts();
        if (products_all_Task.Count == 0)
        {
            Console.WriteLine("No products available.");
        }
        else
        {
            foreach (var product_all_task in products_all_Task)
            {
                Console.WriteLine(product_all_task.GetProductDetails());
            }
        }
        #endregion

        //Update Particular Product
        #region Update Particular Product
        Console.WriteLine("-----View Particular Product Details and Edit -----");
        Console.Write("Enter Product ID to Edit: ");
        if (!int.TryParse(Console.ReadLine(), out int productId_edit_task))
        {
            Console.WriteLine("Invalid ID. Operation cancelled.");
            return;
        }

        var product_edit_task = warehouse2.GetProduct(productId_edit_task);
        if (product_edit_task == null)
        {
            Console.WriteLine("Product not found.");
            return;
        }

        Console.Write("Enter New Name: ");
        string nameProduct_Task = Console.ReadLine();
        Console.Write("Enter New (In-house/3rd Party): ");
        string sourceProduct_Task = Console.ReadLine();
        Console.Write("Enter New Type (e.g., Fruit, Grain): ");
        string typeProduct_Task = Console.ReadLine();
        Console.Write("Enter New Quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity_product_task))
        {
            Console.WriteLine("Invalid quantity. Operation cancelled.");
            return;
        }

        product.Name = string.IsNullOrWhiteSpace(name) ? product.Name : name;
        product.Source = string.IsNullOrWhiteSpace(source) ? product.Source : source;
        //product.Type = string.IsNullOrWhiteSpace(type) ? product.Type : type;
        product.Quantity = quantity;

        Console.WriteLine("Product updated successfully!");
        #endregion
        #endregion

        #region region According to userchoice
        //////Console.WriteLine("Hello, World!");
        ////Console.WriteLine("Warehouse Management System");
        ////Console.WriteLine("1. Add Product");
        ////Console.WriteLine("2. List All Products");
        ////Console.WriteLine("3. View Specific Product");
        ////Console.WriteLine("4. Edit Product");
        ////Console.WriteLine("5. Remove Product");
        ////Console.WriteLine("6. Adjust Stock");
        ////Console.WriteLine("7. Exit");
        ////Console.Write("Choose an option: ");
        ////int userChoice = int.Parse(Console.ReadLine());

        ////Warehouse warehouse = new Warehouse();

        ////#region user choice
        ////if (userChoice == 0)
        ////{
        ////    Console.WriteLine("Please enter correct option!");
        ////}
        ////else if (userChoice == 1)
        ////{
        ////    //AddProduct
        ////    Console.Write("Enter Product Name: ");
        ////    string name = Console.ReadLine();
        ////    Console.Write("Enter Source (In-house/3rd Party): ");
        ////    string source = Console.ReadLine();
        ////    Console.Write("Enter Type (e.g., Fruit, Grain): ");
        ////    string type = Console.ReadLine();
        ////    Console.Write("Enter Quantity: ");
        ////    if (!int.TryParse(Console.ReadLine(), out int quantity))
        ////    {
        ////        Console.WriteLine("Invalid quantity. Operation cancelled.");
        ////        return;
        ////    }

        ////    ProduceProduct newProduct = new ProduceProduct
        ////    {
        ////        ID = warehouse.GetAllProducts().Count + 1,
        ////        Name = name,
        ////        Source = source,
        ////        Type = type,
        ////        Quantity = quantity
        ////    };

        ////    warehouse.AddProduct(newProduct);
        ////    Console.WriteLine("Product added successfully!");

        ////    //GetAllProduct
        ////    var products = warehouse.GetAllProducts();
        ////    if (products.Count == 0)
        ////    {
        ////        Console.WriteLine("No products available.");
        ////    }
        ////    else
        ////    {
        ////        foreach (var product in products)
        ////        {
        ////            Console.WriteLine(product.GetProductDetails());
        ////        }
        ////    }
        ////}
        ////else if (userChoice == 2)
        ////{
        ////    // List all products            
        ////    var products = warehouse.GetAllProducts();
        ////    if (products.Count == 0)
        ////    {
        ////        Console.WriteLine("No products available.");
        ////    }
        ////    else
        ////    {
        ////        foreach (var product in products)
        ////        {
        ////            Console.WriteLine(product.GetProductDetails());
        ////        }
        ////    }
        ////}
        ////else if (userChoice == 3)
        ////{
        ////    // View a specific product
        ////    //var productDetails = warehouse.GetProduct(1);
        ////    //Console.WriteLine(productDetails?.GetProductDetails());
        ////    //
        ////    Console.Write("Enter Product ID: ");
        ////    if (!int.TryParse(Console.ReadLine(), out int productId))
        ////    {
        ////        Console.WriteLine("Invalid ID. Operation cancelled.");
        ////        return;
        ////    }

        ////    var product = warehouse.GetProduct(productId);
        ////    if (product == null)
        ////    {
        ////        Console.WriteLine("Product not found.");
        ////    }
        ////    else
        ////    {
        ////        Console.WriteLine(product.GetProductDetails());
        ////    }
        ////}
        ////else if (userChoice == 4)
        ////{
        ////    // edit a product
        ////    //Console.Write("Enter Product ID: ");
        ////    //if (!int.TryParse(Console.ReadLine(), out int productId))
        ////    //{
        ////    //    Console.WriteLine("Invalid ID. Operation cancelled.");
        ////    //    return;
        ////    //}

        ////    //var product = warehouse.GetProduct(productId);
        ////    //if (product == null)
        ////    //{
        ////    //    Console.WriteLine("Product not found.");
        ////    //}
        ////    //else
        ////    //{
        ////    //    Console.WriteLine(product.GetProductDetails());
        ////    //}
        ////    // 2
        ////    Console.Write("Enter Product ID to Edit: ");
        ////    if (!int.TryParse(Console.ReadLine(), out int productId))
        ////    {
        ////        Console.WriteLine("Invalid ID. Operation cancelled.");
        ////        return;
        ////    }

        ////    var product = warehouse.GetProduct(productId);
        ////    if (product == null)
        ////    {
        ////        Console.WriteLine("Product not found.");
        ////        return;
        ////    }

        ////    Console.Write("Enter New Name (leave blank to keep current): ");
        ////    string name = Console.ReadLine();
        ////    Console.Write("Enter New Source (leave blank to keep current): ");
        ////    string source = Console.ReadLine();
        ////    Console.Write("Enter New Type (leave blank to keep current): ");
        ////    string type = Console.ReadLine();
        ////    Console.Write("Enter New Quantity: ");
        ////    if (!int.TryParse(Console.ReadLine(), out int quantity))
        ////    {
        ////        Console.WriteLine("Invalid quantity. Operation cancelled.");
        ////        return;
        ////    }

        ////    product.Name = string.IsNullOrWhiteSpace(name) ? product.Name : name;
        ////    product.Source = string.IsNullOrWhiteSpace(source) ? product.Source : source;
        ////    //product.GetType = string.IsNullOrWhiteSpace(type) ? product.Type : type;
        ////    product.Quantity = quantity;

        ////    Console.WriteLine("Product updated successfully!");
        ////}
        ////else if (userChoice == 5)
        ////{
        ////    // Remove a product
        ////    //warehouse.RemoveProduct(2);
        ////    //2
        ////    //Console.Write("Enter Product ID to Remove: ");
        ////    //if (!int.TryParse(Console.ReadLine(), out int productId))
        ////    //{
        ////    //    Console.WriteLine("Invalid ID. Operation cancelled.");
        ////    //    return;
        ////    //}

        ////    //if (warehouse.RemoveProduct(productId))
        ////    //{
        ////    //    Console.WriteLine("Product removed successfully!");
        ////    //}
        ////    //else
        ////    //{
        ////    //    Console.WriteLine("Product not found.");
        ////    //}

        ////}
        ////else if (userChoice == 6)
        ////{
        ////    // Adjust stock
        ////    //warehouse.AdjustStock(1, -20);
        ////    //2
        ////    //Console.Write("Enter Product ID: ");
        ////    //if (!int.TryParse(Console.ReadLine(), out int productId))
        ////    //{
        ////    //    Console.WriteLine("Invalid ID. Operation cancelled.");
        ////    //    return;
        ////    //}

        ////    //Console.Write("Enter Quantity to Adjust (use negative numbers to reduce stock): ");
        ////    //if (!int.TryParse(Console.ReadLine(), out int quantity))
        ////    //{
        ////    //    Console.WriteLine("Invalid quantity. Operation cancelled.");
        ////    //    return;
        ////    //}

        ////    //if (warehouse.AdjustStock(productId, quantity))
        ////    //{
        ////    //    Console.WriteLine("Stock adjusted successfully!");
        ////    //}
        ////    //else
        ////    //{
        ////    //    Console.WriteLine("Product not found or insufficient stock.");
        ////    //}
        ////}
        ////else if (userChoice == 7)
        ////{ }
        ////else
        ////{ Console.WriteLine("Please enter correct option!"); }
        #endregion




    }

}
