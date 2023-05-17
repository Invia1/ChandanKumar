using Hospital_Management.Functionality;
using Hospital_Management.Models;
using System;
using System.Collections.Generic;


namespace Hospital_Management.Services
{
    public class PatientServices:IPatientsOperations
    {
        List<Patient> listPatient = new List<Patient>();
        public int createPatient()
        {
            Console.WriteLine("Enter Registraion_No");
            int regId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name Of Patient");
            string fname=Console.ReadLine();
            Console.WriteLine("Enter Last Name Of Patient");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number Of Patient");
            long phoneNo=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Gender Of Patient");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Age Of Patient");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address Of Patient");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Aadhar Number Of Patient");
            long adrno =Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Specilist who you want to Consulted");
            string spls = Console.ReadLine();

            listPatient.Add(new Patient(regId, fname, lname, phoneNo, gender, age, address, adrno, spls));

            Console.WriteLine("Patient Details SuccessFully Added in The List");
            return 1;
        }
        public List<Patient> GetPatientsList()
        {
            return listPatient;
        }
        public void deletePatient()
        {
            Console.WriteLine("Enter Registration_Id");
            int id=Convert.ToInt32(Console.ReadLine());
            foreach(Patient patient in listPatient) 
            {
                if(patient.Registration_D==id)
                {
                    listPatient.Remove(patient);
                    Console.WriteLine("Patient Details SuccessFully Deleted in The List");
                    return;
                }
            }
            Console.WriteLine("Patient is not available in the list");
        }
        public void updatePatient()
        {
            Console.WriteLine("Enter Registration_Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Patient patient in listPatient)
            {
                if (patient.Registration_D == id)
                {
                    Console.WriteLine("Enter the First Name");
                    patient.First_name = Console.ReadLine();
                    Console.WriteLine("Enter the Last Name");
                    patient.Last_name = Console.ReadLine();
                    Console.WriteLine("Enter Mobile Number Of Patient");
                    patient.Phone_no = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter Gender Of Patient");
                    patient.Gender = Console.ReadLine();
                    Console.WriteLine("Enter Age Of Patient");
                    patient.Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Address Of Patient");
                    patient.Address = Console.ReadLine();
                    Console.WriteLine("Enter Aadhar Number Of Patient");
                    patient.Aadhar_No = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter the Specilist who you want to Consulted");
                    patient.Consulted_specilist = Console.ReadLine();

                    Console.WriteLine("Patient Details SuccessFully updated in The List");
                    return;
                }
            }
            Console.WriteLine("Patient is not available in the list");
        }
        public void searchPatient()
        {
            Console.WriteLine("Enter Registration_Id");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Patient patient in listPatient)
            {
                if (patient.Registration_D == id)
                {
                    Console.WriteLine("Show Details when you wanted to search\n");
                    Console.WriteLine("Registration_id:-\t " + patient.Registration_D);
                    Console.WriteLine("First Name:-\t\t " + patient.First_name);
                    Console.WriteLine("Last Name:- \t\t" + patient.Last_name);
                    Console.WriteLine("Mobile Number:-\t\t" + patient.Phone_no);
                    Console.WriteLine("Gender:- \t\t" + patient.Gender);
                    Console.WriteLine("Age:- \t\t\t" + patient.Age);
                    Console.WriteLine("Address:- \t\t" + patient.Address);
                    Console.WriteLine("Aadhar Number:-\t\t " + patient.Aadhar_No);
                    Console.WriteLine("Consulted_Specilist:-\t" + patient.Consulted_specilist);
                    return;
                }
            }
            Console.WriteLine("Patient is not available in the list");
        }
        public void fetchAll()
        {
            foreach (Patient patient in listPatient)
            {
                    Console.Write("Registration_id:-"+" "+ patient.Registration_D);
                    Console.Write("\tFirst Name:-"+" "+ patient.First_name);
                    Console.Write("\tLast Name:-"+" "+ patient.Last_name);
                    Console.Write("\tMobile Number:-"+" " +patient.Phone_no);
                    Console.Write("\t Gender:-"+" "+ patient.Gender);
                    Console.Write("\t Age:-"+" "+ patient.Age);
                    Console.Write("\t Address:-"+" "+ patient.Address);
                    Console.Write("\tAadhar Number:-"+" "+ patient.Aadhar_No);
                    Console.Write("\t Consulted_Specilist:-"+" "+ patient.Consulted_specilist);

                Console.WriteLine();    
            }
            Console.WriteLine("List is empty");
        }
      
        
    }
}
