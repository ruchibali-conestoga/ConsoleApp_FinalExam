using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_FinalExam.AbstractClass
{
    public abstract class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; } // "In-house" or "3rd Party"
        public int Quantity { get; set; }      
        public abstract string GetProductDetails();       
        public void UpdateQuantity(int amount)
        {
            Quantity += amount;
            if (Quantity < 0)
            {
                Quantity = 0;
            }
        }
    }
}
