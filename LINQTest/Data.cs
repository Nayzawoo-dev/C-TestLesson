using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    internal static class Data
    {
        public static int productId = 2;
        public static List<Product> products = new List<Product>()
        {
            new Product(1, "P001", "Apple", 1000, 10, "Fruite"),
            new Product(2, "P002", "Banana", 2000, 20, "Fruite"),
        };
        
        //public static Product[] products2 = new Product[100];   
    }
}
