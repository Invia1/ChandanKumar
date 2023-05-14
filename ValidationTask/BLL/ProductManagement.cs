using System;
using System.Collections;
using System.Text.RegularExpressions;
using ValidationForColumn.Models;

namespace ValidationForColumn.BLL
{
    class ProductManagement
    {
       
       public Product addProduct()
        {
           
            Product product = new Product();
            Console.WriteLine("Enter The Product Id");
            product.PID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Product Name");
            product.Name = Console.ReadLine();
            Console.WriteLine("Enter The Product Brand");
            product.Brand = Console.ReadLine();
            Console.WriteLine("Enter The Product Price");
            product.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Product Quantity");
            product.Quant = Convert.ToInt32(Console.ReadLine());
            return product;
        }
      
    }
}
