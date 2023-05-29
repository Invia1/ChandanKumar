delegate string timingDelegate();
delegate int feeDelegate();
class College
{
   public int fees()
    {
       return 6000;
    }
    public string timing()
    {
        return "Morning 9:00 AM";
    }
    public string Rules()
    {
        return "Follow All Rules";
    }
    public int duration()
    {
        return 2;
    }
}
class Student
{
    public static void Main()
    {
        College obj=new College();
        timingDelegate mydel = new timingDelegate(obj.timing);
      
        var temp = mydel();
        Console.WriteLine(temp);
        mydel += obj.Rules;
        var temp2=mydel();
        Console.WriteLine(temp2);

        feeDelegate mydel2 = new feeDelegate(obj.fees);
        var temp3 = mydel2();
        Console.WriteLine(temp3);
        mydel2 += obj.duration;
        var temp4=mydel2();
        Console.WriteLine(temp4);
    }
}