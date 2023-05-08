using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class PraticeDay3
    {
        readonly int Id;
        string name;

        static string address;
        static readonly int lwp;
        const int eyears=1998;
        int YearOfCompany;
        

        public PraticeDay3(int id,string name)
        {
            this.Id = id;
            this.name = name;
        }
        static PraticeDay3()
        {
            address = "Sector 58, Noida";
            lwp = 3;
        }
        public void ChangeName(string n)
        {
           name = n;    
        }
        public void Display()
        {
            Console.WriteLine("Id"+"====" +Id);
            Console.WriteLine("Name" + "====" + name);
            Console.WriteLine("Address" + "====" + address);
            Console.WriteLine("LWP" + "====" + lwp);
            Console.WriteLine("Establisted_year" + "====" + eyears);
        }
        public static void Main()
        {
            var obj =new PraticeDay3(101,"Invia");
            obj.Display();
            Console.WriteLine();

            obj.ChangeName("Invia Technology And Services");
            obj.Display();


            Console.ReadLine();
        }
    }
}
