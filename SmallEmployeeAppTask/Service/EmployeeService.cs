using Day8.Models;
using System;


namespace Day8.Service
{
    public class EmployeeService
    {
       List<Employee> objList= new List<Employee>();
       public int CreateEmployee(Employee emp)
        {
            objList.Add(emp);
            return 1;
        }
        public List<Employee> GetEmployeeList()
        {
            Console.WriteLine("Show All Employee in the List");
            return objList;
        }
        public void removeEmployee(int id) 
        { 
            foreach (Employee emp in objList)
            {
                if (emp.EID == id)
                {
                    Console.WriteLine($"Data remove in the List=={id}");
                    objList.Remove(emp);
                    return;
                }
            }
            Console.WriteLine("Not available in the List");  
              

        }
        public void updateEmployee(int id) 
        {
            foreach (Employee emp in objList)
            {
                if (emp.EID == id)
                {
                    Console.WriteLine($"New Data Update in the List particular Id=={id}");
                    emp.Ename = "Radha";
                    emp.Age = 22;
                    return;
                }  
            }
            Console.WriteLine("Not available in the LIst");
            
        }
        public void searchEmployee(int id) 
        {
            foreach (Employee emp in objList) 
            {
                if (emp.EID == id)
                {
                    Console.WriteLine($"Searching data is Available in the list Id=={id}");
                    Console.WriteLine(emp.EID+" "+emp.Ename+" " + emp.Age);
                    return;
                }
            }
             Console.WriteLine("Not available in the LIst");
        }
        public int insertEmployee(Employee e)
        {
            Console.WriteLine("Insert employee in the list in particular index");
            objList.Insert(5, e);
            return 1;
        }
     
    }
}
