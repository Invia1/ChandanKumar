using System;
using System.Collections.Generic;
using FriendAppCustomised.Functionality;
using FriendAppCustomised.Models;


namespace FriendAppCustomised.Service
{
    public class FriendService:IFriendOperation
    {
       List<Friend> objList=new List<Friend> ();
       public void createFriend()
        {
            Console.WriteLine("Enter Friend Id:");
            int fid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Friend Age:");
            int fage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend Address:");
            string faddress = Console.ReadLine();
            Console.WriteLine("Enter Friend MobileNo.:");
            int contactNo = Convert.ToInt32(Console.ReadLine());
           
            objList.Add(new Friend(fid, fname, faddress, fage, contactNo));
            Console.WriteLine("Friend Created in the list\n");
            return;
        }
        public List<Friend> getFriendList()
        {
            
            
            foreach (Friend f in objList) 
            {
                Console.WriteLine("Show All the data in the List");
                Console.WriteLine($"ID: {f.fId}, Name: {f.fName}, Address:{f.fAddress},Age:{f.fAge}, MobileNo:{f.contactNo}");
               
            }
            return objList;
            Console.WriteLine("List is Empty");
            

        }
        public void removeFriend()
        {
            Console.WriteLine("Enter Friend Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Friend f in objList) 
            {
                if (f.fId == id)
                {
                    objList.Remove(f);
                    return;
                }
            }
            Console.WriteLine("Friend Id is not Available in the list");
        }
        public void updateFriend()
        {
            Console.WriteLine("Enter Friend Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Friend f in objList)
            {
                if (f.fId == id)
                {
                    Console.WriteLine("enter New data in the object and add in the list ");
                    f.fName = Console.ReadLine();
                    f.fAddress= Console.ReadLine();
                    f.fAge=Convert.ToInt32(Console.ReadLine());
                    f.contactNo=Convert.ToInt32(Console.ReadLine());
                    return;
                }
            }
            Console.WriteLine("Friend Id is not Available in the list");
        }
        public void searchFriend()
        {
            Console.WriteLine("Enter Friend Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Friend f in objList)
            {
                if (f.fId == id)
                {
                    Console.WriteLine($"Searching data is Available in the list Id=={id}");
                    Console.WriteLine($"ID: {f.fId}, Name: {f.fName}, Address:{f.fAddress},Age:{f.fAge}, MobileNo:{f.contactNo}");
                    return;
                }
            }
            Console.WriteLine("Not available in the LIst");
        }
        public void insertFriend()
        {
            Console.WriteLine("Enter the Index for set the value");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend Name:");
            string Iname = Console.ReadLine();
            Console.WriteLine("Enter Friend Age:");
            int Iage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Friend Address:");
            string Iaddress = Console.ReadLine();
            Console.WriteLine("Enter Friend MobileNo.:");
            int IcontactNo = Convert.ToInt32(Console.ReadLine());
            objList.Insert(n, new Friend(n,Iname,Iaddress,IcontactNo,Iage));
            return;
        }
    }
}
