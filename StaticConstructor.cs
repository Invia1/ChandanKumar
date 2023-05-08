class StaticConstructor
{
    static string officeAddress;
    static readonly int lwp;

    static StaticConstructor()
    {
        officeAddress = "LajpatNagar";
        lwp = 2;
    }
    public static void Main()
    {
        Console.WriteLine(officeAddress);
        
        Console.WriteLine(lwp);

   //     lwp = 4;

        officeAddress = "noida";

       Console.WriteLine(lwp+" "+officeAddress);
    }

}