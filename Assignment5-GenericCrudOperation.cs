using System;
using System.Collections.Generic;


namespace day7_Collection_Generic
{
    class Countries
    {
        List<string> countries = new List<string>
        {
            "india",
            "Russia",
            "USA",
            "SwitzeLand",
            "Japan",
            "Germany"
        };
        public void Entry(string str)
        {
            Console.WriteLine("Add Element in the List\n");
            countries.Add(str);
            foreach (string temp in countries)
            {
                Console.WriteLine(temp);
            }
            Console.WriteLine();
        }
        public void removeData(string str)
        {
            if (countries.Contains(str))
            {
                countries.Remove(str);
                Console.WriteLine("Show List After Remove the Element \n ");
                foreach (string temp in countries)
                {
                    Console.WriteLine(temp);
                }
            }
            else
                Console.WriteLine("Element is not Available in the list");
            Console.WriteLine() ;
        }
        public void SearchData(string str)
        {
            var search=countries.Contains(str);
            if(search==true)
               Console.WriteLine("Element is Available in the list");
            else
                Console.WriteLine("Element is Not Available in the list");
        }
        public void updateData(string str)
        {
            if (countries.Contains(str))
            { 
                Console.WriteLine("Element is available,Lets Update:\n ");
                countries.Remove(str);
                Console.Write("Enter the new data:-");
                string str2 = Console.ReadLine();
                countries.Add(str2);
                foreach(string temp in countries)
                {
                    Console.WriteLine($"{temp}");
                } 
            }
            else
                Console.WriteLine("Element is not available in list");

            Console.WriteLine();
        }
        public void fetchAllData()
        {
            Console.WriteLine("Show All Element in  the List\n");
            foreach (string temp in countries) 
            { 
                Console.WriteLine(temp);
            }
        }
    }
    class CountriesList
    {
        public static void Main()
        {
            var obj= new Countries();
            bool check = true;
            while (true)
            {
                Console.WriteLine("1:Add in the list:-");
                Console.WriteLine("2:Remove in the list:-");
                Console.WriteLine("3:Search in the list:-");
                Console.WriteLine("4:Update in the list:-");
                Console.WriteLine("5:FetchAll in the list:-");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter element add in the list:-");
                        var str1 = Console.ReadLine();
                        obj.Entry(str1);
                        break;

                    case 2:
                        Console.WriteLine("which data remove from the list:-");
                        var str2 = Console.ReadLine();
                        obj.removeData(str2);
                        break;

                    case 3:
                        Console.WriteLine("Enter element search in the list:-");
                        var str3 = Console.ReadLine();
                        obj.SearchData(str3);
                        break;
                    case 4:
                        Console.WriteLine("Check element available in the list then update otherwise not available :-");
                        var str4 = Console.ReadLine();
                        obj.updateData(str4);
                        break;

                    case 5:
                        obj.fetchAllData();
                        break;

                     case 6:
                        check = false; 
                        break;
                }
            }
        }
    }
}
