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
            Console.WriteLine("Add data in list  used \n");
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
                Console.WriteLine("After the remove function print list \n ");
                foreach (string temp in countries)
                {
                    Console.WriteLine(temp);
                }
            }
            else
                Console.WriteLine("Data is Not Available in the list");
            Console.WriteLine() ;
        }
        public void SearchData(string str)
        {
            var search=countries.Contains(str);
            Console.WriteLine("Search data in list \n ");
            if(search==true)
               Console.WriteLine("Data is Available in the list");
            else
                Console.WriteLine("Data is Not Available in the list");
        }
        public void updateData(string str)
        {
            if (countries.Contains(str))
            { 
                Console.WriteLine("Available, Check if the data is correct otherwise update \n ");
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
                Console.WriteLine("Data is Not available in list");

            Console.WriteLine();
        }
        public void fetchAllData()
        {
            Console.WriteLine("Show All Data In  the List\n");
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
            Console.WriteLine("Enter 1 for Element add in the list:-");
            Console.WriteLine("Enter 2 for  Element remove in the list:-");
            Console.WriteLine("Enter 3 for Element Search in the list:-");
            Console.WriteLine("Enter 4 for Element update in the list:-");
            Console.WriteLine("Enter 5 for Element fetchall in the list:-");
            Console.WriteLine("Enter your Choice");
            int choice=Convert.ToInt32(Console.ReadLine());
            while (true)
            {
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
                }
                Console.WriteLine("If you want perform any other operation in the list");
                string str = Console.ReadLine();
                if (str == "yes")
                    Main();
                else
                    Console.WriteLine("terminated program");
                break;
            
            }
        }
    }
}
