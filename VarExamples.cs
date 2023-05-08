using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class PersonDetails
    {
        string pname;

        public void ChangeName(String n)
        {
            pname = n;
            var name = "Chandan"; // var ="string";
            name = "Bhuwan";
            Console.WriteLine(name);
        }

        public static void Main()
        {
            var obj = new PersonDetails();
            obj.pname = "deepa";
            Console.WriteLine(obj.pname);
            obj.pname = "Deepak Shrivastava";

            obj.ChangeName("RadheShyam");
            Console.WriteLine(obj.pname);
        }
    }
}