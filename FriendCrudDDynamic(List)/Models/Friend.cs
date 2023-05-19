using System;

namespace FriendAppCustomised.Models
{
    public class Friend
    {
        public int fId { get; set; }
        public string fName { get; set; }

        public string fAddress { get; set; } 

        public int fAge { get; set; }

        public int contactNo { get; set; }

        public Friend(int id,string name,string address,int age,int mobno)
        {
            this.fId = id;
            this.fName = name;        
            this.fAddress = address;
            this.fAge = age;
            this.contactNo = mobno;
        }
    }

}
