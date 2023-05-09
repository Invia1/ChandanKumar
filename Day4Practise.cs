using System;
// what is properties
//properties is a mechanism to access private variable of class.
//To access the private variable of class , we have to apply get and set accessor.

//1.There are two ways to access the private varibale of a class
//A. properties    B. Function or method

//Achieved encapsulation (wrapper) via properties.
class person
{
    int ID;     // private
    string pName;// private
    int age;

    personDetails details = new personDetails();
    public int PID
    {
        get
        {
            return ID;
        }
        set
        {
            ID = value; // value is a keyword in C# and generally we apply set a value in variable. Act as a Temporary variable
        }
    }
    public string PNAME
    {
        get
        {
            return pName;
        }
        set
        {
            pName= value; // value is a keyword in C# and generally we apply set a value
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set 
        { 
            age = value; 
            if(age<20)
            {
                
                details.Nofit();
            }
            else
            {
                details.Scheduled();
            }
        }
    }
}

class personDetails
{
    public void Nofit()
    {
        Console.WriteLine("Criteria Not Match..........Thanks");
    }
    public void personInfo()
    {
        person obj=new person();
        obj.PID = 101;
      //  Console.WriteLine(obj.PID);

        obj.PNAME = "Chandan Kumar";
      //  Console.WriteLine(obj.PNAME);

        obj.Age = 21;
     //   Console.WriteLine(obj.Age);
       
       
    }
    public void Scheduled()
    {
        Console.WriteLine("wait for final Call");

    }
}
class startup
{
    public static void Main()
    {
        var pdetails = new personDetails();
        pdetails.personInfo();
    }
}