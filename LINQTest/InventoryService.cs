using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    internal class InventoryService
    {
        public void  CreateProduct() {
            Console.WriteLine("Product Management System");

            Console.Write("Input Product Name: ");

            string ProductName = Console.ReadLine()!;
        BeforePrice:
            Console.Write("Input Product Price: ");



            //try
            //{
            //    decimal Price = Convert.ToDecimal(Console.ReadLine()!);
            //    if (!(Price is decimal))
            //    {
            //        //Console.WriteLine("Invalid Number");
            //        throw new Exception("Invalid Case");

            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Invalid Case");
            //    goto BeforePrice;
            //}

            string Price = Console.ReadLine()!;

            bool isDecimal = Decimal.TryParse(Price, out decimal ProductPrice);

            if (isDecimal is false) //if (isDecimal is false){} my own formula
            {
                Console.WriteLine("Invalid Case");
                goto BeforePrice;
            }

        BeforeQuantity:
            Console.Write("Input Product Quantity: ");



            //try
            //{
            //    int Quantity = Convert.ToInt32(Console.ReadLine()!);
            //    if (!(Quantity is int))
            //    {
            //        //Console.WriteLine("Invalid Number");
            //        throw new Exception("Invalid Case");

            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Invalid Case");
            //    goto BeforeQuantity;
            //}

            string Quantity = Console.ReadLine()!;

            bool isInt = int.TryParse(Quantity, out int ProductQuantity);

            if (!isInt) //if (isDecimal is false){} my own formula
            {
                Console.WriteLine("Invalid Case");
                goto BeforeQuantity;
            }


            Data.productId++;
            string productCode = "P" + Data.productId.ToString().PadLeft(3, '0');
            Product product = new Product(Data.productId, productCode, ProductName, ProductPrice, ProductQuantity, "Fruite");
            Data.products.Add(product);
            //Data.products2[Data.productId - 1] = product;
            Console.WriteLine("Insert Successfully!");
        }
        public void ViewProduct() {
            Console.WriteLine("Product List");
            foreach (var item in Data.products) {
                Console.WriteLine($"Id : {item.Id}, Code : {item.Code}, Name : {item.Name}, Price : {item.Price}, Quantity : {item.Quantity}, Category : {item.Category}");

            }
        }

    }

}
