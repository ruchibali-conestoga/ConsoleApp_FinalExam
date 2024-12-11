using ConsoleApp_FinalExam.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_FinalExam.ConcreteClass
{
    public class ProduceProduct : Product
    {
        public string Type { get; set; } // e.g., "Fruit", "Vegetable", "Grain"

        public override string GetProductDetails()
        {
            return $"ID: {ID}, Name: {Name}, Source: {Source}, Type: {Type}, Quantity: {Quantity}";
        }
    }
}
