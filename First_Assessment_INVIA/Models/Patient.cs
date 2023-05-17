using System;
using System.Collections.Generic;
using System.Numerics;


namespace Hospital_Management.Models
{
    public class Patient
    {
        public int Registration_D{get;set;}
        public string First_name{get;set;}
        public string Last_name{get; set;}
        public long Phone_no{get; set;}
        public string Gender{get; set;}
        public int Age{get; set;}
        public string Address{get; set;}
        public long Aadhar_No{get; set;}
        public string Consulted_specilist{ get; set;}


        public Patient(int registration_D, string first_name, string last_name, long phone_no, string gender, int age, string address, long aadhar_No, string consulted_specilist)
        {
           this.Registration_D = registration_D;
           this.First_name = first_name;
           this.Last_name = last_name;
           this.Phone_no = phone_no;
           this.Gender = gender;
           this.Age = age;
           this.Address = address;
           this.Aadhar_No = aadhar_No;
           this.Consulted_specilist = consulted_specilist;
        }
    }
}
