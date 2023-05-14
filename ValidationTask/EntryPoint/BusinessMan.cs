using System;
using ValidationForColumn.BLL;
using ValidationForColumn.Models;

namespace ValidationForColumn.EntryPoint
{
    class BusinessMan
    {
        public static void Main()
        {

            var obj = new ProductManagement();
            Product temp = obj.addProduct();

            Console.WriteLine("Product-ID=" + "\t\t" + temp.PID);
            Console.WriteLine("Product-Name=" + "\t\t" + temp.Name);
            Console.WriteLine("Product-Brand=" + "\t\t" + temp.Brand);
            Console.WriteLine("Product-Price=" + "\t\t" + temp.Price);
            Console.WriteLine("Product-Quantity=" + "\t" + temp.Quant);
            Console.ReadLine();
        }


    }
}
