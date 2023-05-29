delegate int feesDelegate(int n);
class Doctor
{
    public int fees(int n)
    {
        return n;
    }
}
class patient
{
    public static void Main()
    {
        Doctor doctor = new Doctor();
        feesDelegate mydel=new feesDelegate(doctor.fees);
        var temp = mydel(500);
        Console.WriteLine(temp);
    }
}