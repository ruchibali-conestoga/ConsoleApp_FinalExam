using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FinalExam.Interface
{
    public interface IProductOperations
    {
        void AddProduct(Product product);
        void RemoveProduct(int productId);
        void EditProduct(int productId, Product updatedProduct);
        Product GetProduct(int productId);
        List<Product> GetAllProducts();
        void AdjustStock(int productId, int quantity);
    }
}
