using System;
using System.Text.RegularExpressions;




namespace ValidationForColumn.Models
{
    class Product
    {
        int pid;
        string name;
        int price;
        int quantity;
        string brand;


        public int PID
        {

            get
            {
                return pid;
            }
            set
            {
                    pid = value;  
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
                {
                    name = value;
                }
                else
                {

                    while (true)
                    {
                        Console.WriteLine("Digit is not allow.Please enter again Correct Name ");
                        string s = Console.ReadLine();
                        if (Regex.IsMatch(s, "^[a-zA-Z ]+$"))
                        {
                            name = s; break;
                        }
                    }

                }


            }

        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {

                price = value;

            }
        }
        public int Quant
        {
            get
            {
                return quantity;
            }
            set
            {

                quantity = value;

            }
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z ]+$"))
                {
                    brand = value;
                }
                else
                {

                    while (true)
                    {
                        Console.WriteLine("Digit is not allow.Please enter again Correct Brand ");
                        string b = Console.ReadLine();
                        if (Regex.IsMatch(b, "^[a-zA-Z ]+$"))
                        {
                            brand = b; break;
                        }
                    }

                }

            }

        }
    }
}
