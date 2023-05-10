using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Journey
    {
        object[] myLuggage = new object[5];

        public object this[int i]
        {
            get
            {
                return myLuggage[i];
            }
            set
            {
                myLuggage[i] = value;
            }
        }


        public static void Main()
        {
            Journey obj= new Journey();
            obj[0] = "Towel";
            obj[1] = "Soap";
            obj[2] = "Ticket";
            obj[3] = "Document";
            obj[4] = 100;

            Console.WriteLine(obj[0]+"\n" + obj[1]+"\n"+obj[2] +"\n"+ obj[3] +"\n"+ obj[4]);

            Journey obj2 = new Journey();
            obj2[0] = "Towel";
            obj2[1] = "Soap";
            obj2[2] = "Ticket";
            obj2[3] = "Document";
            obj2[4] = 100;

            Console.WriteLine();

            Console.WriteLine(obj2[0] + "\n" + obj2[1] + "\n" + obj2[2] + "\n" + obj2[3] + "\n" + obj2[4]);

        }
    }
}
