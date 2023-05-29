delegate void SplDelegate();
class Doctor2
{
    public void Specialist()
    {
        Console.WriteLine("ENT");
    }
    public void Prescription()
    {
        Console.WriteLine("Don't keep medicine in front of Children");
    }

}
class Patient2
{
    public static void Main()
    {
        Doctor2 obj = new Doctor2();
        SplDelegate mydel = new SplDelegate(obj.Specialist);
        mydel();
        mydel += obj.Prescription;
        mydel();
    }
}