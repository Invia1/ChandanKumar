using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Session
{
    class Bank
    {
        int AccNo;
        string name;
        int panCardNo;

        public int ACCNO
        {
            get
            { 
                return AccNo; 
            }
            set
            { 
                AccNo = value; 
            }
        }
        public string CName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int PanCardNo
        {
            get
            {
                return panCardNo;
            }
            set
            {
                panCardNo = value;
            }
        }
    }
    class BankManagement
    {
        public void CustomerInfo()
        {
            var obj= new Bank();
            obj.ACCNO = 33375388;
            Console.WriteLine(obj.ACCNO);
            obj.CName = "Chandan Kumar";
            Console.WriteLine(obj.CName);
            obj.PanCardNo = 84003537;
            Console.WriteLine(obj.PanCardNo);

        }

    }
    class Customer
    {
        static void Main()
        {
            var obj=new BankManagement();
            obj.CustomerInfo();
 
        }
    }
}
