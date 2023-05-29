class University
{
    public void duration(string str,string year)
    {
        Console.WriteLine(str+""+year);
    }
    public void Fees()
    {
        Console.WriteLine("This is Mandatory for Everyone");
    }
    public void FeesTotal(int n)
    {
        Console.WriteLine(n);
    }
    public void Rules(string r,string d)
    {
        Console.WriteLine("Follow the Rules and every time have a discipline");
    }
}
class Bachelorstd
{
    public static void Main()
    {
       University obj=new University();
       Action<string,string> myd = obj.duration;
       myd("B.tech","4 years");
       myd = obj.Rules;
       myd("Guideline","Always have in Disciplined");

       Action myd2 = obj.Fees;
       myd2();

       Action<int> myd3 = obj.FeesTotal;
       myd3(950000);



    }
}