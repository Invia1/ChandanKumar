using System;
using Day8.Models;
using Day8.Service;


namespace Day8.UI
{
    public class MainApp
    {
       public static void Main()
        {
            var obj =new Employee();
            obj.EID = 1;
            obj.Ename = "Chandan";
            obj.Age = 25;

            var es=new EmployeeService();   
            es.CreateEmployee(obj);

            var obj2=new Employee();
            obj2.EID = 2;
            obj2.Ename = "Satish";
            obj2.Age = 28;
            es.CreateEmployee(obj2);

            var obj3 = new Employee();
            obj3.EID = 3;
            obj3.Ename = "Pawan";
            obj3.Age = 32;
            es.CreateEmployee(obj3);
            var obj4= new Employee();
            obj4.EID = 4;
            obj4.Ename = "Ajay";
            obj4.Age = 36;

            es.CreateEmployee(obj4);
            var obj5 = new Employee();
            obj5.EID = 5;
            obj5.Ename = "Vijay";
            obj5.Age = 40;

            es.CreateEmployee(obj5);
            var obj6 = new Employee();
            obj6.EID = 6;
            obj6.Ename = "Uma";
            obj6.Age = 45;

            es.CreateEmployee(obj6);
            var obj7 = new Employee();
            obj7.EID =7;
            obj7.Ename = "Rohit";
            obj7.Age = 22;

            es.CreateEmployee(obj7);
            List<Employee> objList=es.GetEmployeeList();
            foreach(var temp in objList) 
            {
                Console.WriteLine(temp.EID+" "+temp.Ename+" "+temp.Age);
            }
            Console.WriteLine("\n");

            es.removeEmployee(2);
            foreach (var temp in objList)
            {
                Console.WriteLine(temp.EID + " " + temp.Ename + " " + temp.Age);
            }

            Console.WriteLine("\n");
            es.updateEmployee(3);
        
            foreach (var temp in objList)
            {
                Console.WriteLine(temp.EID + " " + temp.Ename + " " + temp.Age);
            }
            Console.WriteLine();
            es.searchEmployee(7);

            Console.WriteLine("\n");

            var n=new Employee();
            n.EID = 10;
            n.Ename = "pooja";
            n.Age = 22;

            es.insertEmployee(n);
            foreach (var temp in objList)
            {
                Console.WriteLine(temp.EID + " " + temp.Ename + " " + temp.Age);
            }









        }
    }
}
