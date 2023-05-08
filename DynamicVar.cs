using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class PersonDetails2
    {
            string pname;

            public void ChangeName(String n)
            {
                pname = n;
                dynamic name = "Chandan"; // var ="string";
                name = 2.5;
                Console.WriteLine(name);
            }

            public static void Main()
            {
                var obj = new PersonDetails2();
                obj.pname = "deepa";
                Console.WriteLine(obj.pname);

                obj.pname = "Deepak Shrivastava";
                Console.WriteLine(obj.pname);


                obj.ChangeName("RadheShyam");
                Console.WriteLine(obj.pname);
            }
        }
    }
