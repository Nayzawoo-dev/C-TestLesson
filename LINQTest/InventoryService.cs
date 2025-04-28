using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    internal class InventoryService
    {
        public void CreateProduct()
        {
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
        public void ViewOldProduct()
        {
            Console.WriteLine("Product List");
            foreach (var item in Data.products)
            {
                Console.WriteLine($"Id : {item.Id}, Code : {item.Code}, Name : {item.Name}, Price : {item.Price}, Quantity : {item.Quantity}, Category : {item.Category}");

            }
        }

        public void UpdateProduct()
        {
        BeforeCode:
            Console.Write("Input Product Code: ");
            string code = Console.ReadLine()!;



            foreach (var item in Data.products)
            {
                Data.newArr.Add(new Product(item.Id, item.Code, item.Name, item.Price, item.Quantity, item.Category));
            }
            var item2 = Data.newArr.FirstOrDefault(p => p.Code == code);
            if (item2 is null)
            {
                Console.WriteLine("Product Not Found");
                goto BeforeCode;
            }

            Console.WriteLine("Product is found.");
            Console.WriteLine($"Code : {item2.Code}, Name : {item2.Name}, Quantity : {item2.Quantity}");
        BeforeQuantity:
            Console.Write("Insert Quantity: ");
            string quantity = Console.ReadLine()!;
            bool quantityResult = int.TryParse(quantity, out int ProductQuantity);
            if (quantityResult is false)
            {
                Console.WriteLine("Invalid Case");
                goto BeforeQuantity;
            }

            item2.Quantity -= ProductQuantity;
            Console.WriteLine("Product Updated Successfully");

        }
        public void DeleteProduct()
        {
        BeforeId:
            Console.Write("Insert Product Id: ");
            string insertId = Console.ReadLine()!;
            bool isId = int.TryParse(insertId, out int ProductId);
            if (isId is false)
            {
                Console.WriteLine("Invalid Id");
                goto BeforeId;
            }



            var deleteId = Data.products.FirstOrDefault(p => p.Id == ProductId);
            if (deleteId is null)
            {
                Console.WriteLine("Invalid Id");
                goto BeforeId;
            }

            Data.products.Remove(deleteId);


        }

        public void ViewUpdateProduct()
        {
            foreach (var newarr in Data.newArr) {
                Console.WriteLine($"Id : {newarr.Id}, Code : {newarr.Code}, Name : {newarr.Name}, Price : {newarr.Price}, Quantity : {newarr.Quantity}, Category : {newarr.Category}");
            }
        }

    }
}