using ConsoleApp_FinalExam.AbstractClass;
using ConsoleApp_FinalExam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FinalExam
{
    public class Warehouse //: IProductOperations
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Product {product.Name} added successfully.");
        }

        public void RemoveProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.ID == productId);
            if (product != null)
            {
                products.Remove(product);
                Console.WriteLine($"Product {product.Name} removed successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void EditProduct(int productId, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.ID == productId);
            if (product != null)
            {
                product.Name = updatedProduct.Name;
                product.Source = updatedProduct.Source;
                product.Quantity = updatedProduct.Quantity;
                Console.WriteLine($"Product {productId} updated successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public Product GetProduct(int productId)
        {
            return products.FirstOrDefault(p => p.ID == productId);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public void AdjustStock(int productId, int quantity)
        {
            var product = products.FirstOrDefault(p => p.ID == productId);
            if (product != null)
            {
                product.UpdateQuantity(quantity);
                Console.WriteLine($"Stock for product {product.Name} adjusted by {quantity}. New quantity: {product.Quantity}.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }
    }
}
