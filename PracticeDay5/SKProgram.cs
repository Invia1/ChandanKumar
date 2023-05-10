using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class person2
    {
        object[] mydata = new object[4];   //myadat is a array of object type

        public object this[int i]    //obj[0]
        {
            get
            {
                return mydata[i];
            }
            set
            {
                mydata[i] = value;
            }
        }
    }

    class personDetails2
    {
        public static void Main()
        {
            person2 obj = new person2();   //obj=this
            obj[0] = "ravi";     //mydata[0]
            obj[1] = "btech";    //mydata[1]
            obj[2] = "21";

            Console.WriteLine(obj[0] + " " + obj[1] + " " + obj[2]);
        }
    }
}
