using System;
using System.Collections;


namespace ArrayListCrud
{
    class Product
    {
        ArrayList product = new ArrayList();
        public void AddElement()
        {
            Console.WriteLine("1:- Adding the data into ArrayList:-");
            product.Add(1);
            product.Add("Mouse");
            product.Add(2);
            product.Add("Laptop");
            product.Add("Keyboard");
            product.Add("USB Cable");
            product.Add("Printer");
            foreach (var temp in product)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }
        public void insertElement()
        {
            Console.WriteLine("5:- Insert the data into ArrayList:-");
            product.Insert(2, "SSD");
            Console.WriteLine("Insert data in particular index");
            foreach (var temp in product)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }
        public void removeData()
        {
                product.Remove(1);
                product.Remove("USB Cable");
                Console.WriteLine("2:- After the remove function print list :- ");
                foreach (var temp in product)
                {
                    Console.WriteLine(temp);
                }
        }
        public void searchElement()
        {
            product.Contains("Laptop");
            if (true)
                Console.WriteLine("3:- " + "Element Found in the list");
            else
                Console.WriteLine("Not Available");
        }
        public void updateElement()
        {
            product.Contains("Laptop");
            if (true)
            {
                product.Remove("Laptop");
                product.Add("Dell Laptop");
                Console.WriteLine("4:- List of data After Update");
                foreach(var temp in product)
                {
                    Console.WriteLine($"{temp}");
                }
            }
            else
                Console.WriteLine("Not Available");
        }
        public void fetchAll()
        {
            Console.WriteLine("6:- Show All Data in the List");
            foreach (var temp in product)
            {
                Console.WriteLine(temp);
            }
        }

        public static void Main()
        {
            Product product = new Product();
            product.AddElement();
            product.removeData();
            Console.WriteLine();
            product.searchElement();
            Console.WriteLine();
            product.updateElement();
            Console.WriteLine();
            product.insertElement();
            Console.WriteLine();
            product.fetchAll();
        }
    }
}