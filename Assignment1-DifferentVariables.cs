using System;

class Invia
{
    readonly string RegId;
    string name;
    string description;


    static string address;
    static readonly string website;
    static int phoneno;
    const int eyear = 2007;

    public Invia(string regid, string n, string desc)
    {
        this.RegId = regid;
        this.name = n;
        this.description = desc;
    }
    static Invia()
    {
        address = "Sector 58,Noida";
        phoneno = 1112223334;
        website = "www.invia.co.in";
    }
    public void display()
    {
        Console.WriteLine("Registration No. =" + RegId);
        Console.WriteLine("Company Name     =" + name);
        Console.WriteLine("Description      =" + description);
        Console.WriteLine("Address          =" + address);
        Console.WriteLine("Mob No.          =" + phoneno);
        Console.WriteLine("Established Year =" + eyear);
        Console.WriteLine("Company Website  =" + website);


    }
    public static void Main()
    {
        Invia invia = new Invia("Hitech#234567","Invia","IT Technology & Services");
        invia.display();
        Console.ReadLine();
    }



}
