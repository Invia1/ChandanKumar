using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Session
{
    class ShoppingMall
    {
        int cId;
        string name;
        int amount;

        ShoppingDesc obj=new ShoppingDesc();
        public int CID
        {
            get
            {
                return cId; ;
            }
            set
            {
                cId = value;
            }
        }
        public string CName
        {
            get
            {
                return name; ;
            }
            set
            {
                name= value;
            }
        }
        public int Amount
        {
            get
            {
                return amount; 
            }
            set
            {
                amount = value;
                if (amount < 10000)
                    obj.notApplicableShopping();
                else
                    obj.applicabeShopping();
            }     
        }
    }
    class ShoppingDesc
    {
        public void purchase(int balance)
        {
            if (balance > 10000)
            {
                Console.WriteLine("Waw You are valuable Customer");
                Console.WriteLine();
                var obj = new ShoppingMall();
                Console.WriteLine("Enter customer Id:-");
                obj.CID=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Customer Name:- ");
                obj.CName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("ThankYou for Visiting Shopping Mall");
            }
            else
                Console.WriteLine("You are not applicable and will be allowing minimum 10000 Rupees");
        }
        public void applicabeShopping()
        {
            Console.WriteLine("More shopping and More Enjoy");
        }
        public void notApplicableShopping()
        {
            Console.WriteLine("you are not applicable for shopping");
        }
    }
    class Customer2
    {
        static void Main() 
        {
            Console.Write("Check your current account balance:-");
            int balance=Convert.ToInt32(Console.ReadLine());
            var obj=new ShoppingDesc();
            obj.purchase(balance);
            Console.ReadLine();
        }
    }
}
