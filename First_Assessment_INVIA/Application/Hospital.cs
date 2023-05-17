using Hospital_Management.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Application
{
    public class Hospital
    {
        public static void Main()
        {
            PatientServices ps = new PatientServices();
            void display()
            {
                Console.WriteLine("1:Add the Patients Details");
                Console.WriteLine("2:Delete the Patients Details");
                Console.WriteLine("3:Update the Patients Details");
                Console.WriteLine("4:Search the Patients Details");
                Console.WriteLine("5:Fetch All the Patients Details");
            }
            bool check=true;
            while (check) 
            {
                display();
                Console.WriteLine("Enter Your Choice");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch(choice) 
                { 
                    case 1:
                        ps.createPatient();
                        break;
                    case 2:
                        ps.deletePatient();
                        break;
                    case 3:
                        ps.updatePatient();
                        break;
                    case 4:
                        ps.searchPatient();
                        break;
                    case 5:
                        ps.fetchAll();
                        break;
                    case 6:
                        check=false; break; 
                    default: 
                        Console.WriteLine("You are enter wrong choice");
                        break;
               Console.ReadLine();
                }
                
            }
        }
    }
}
