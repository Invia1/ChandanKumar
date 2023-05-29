class CheckString
{
    public static void Main()
    {
        Predicate<String> mydel = (str) =>
        {
            if (str.Length >= 5)
                return true;
            return false;
        };
        var temp=mydel("Chandan");
        Console.WriteLine("Check string length"+"=="+temp);


        Predicate<int> my = (n) =>
        {
            if (n > 0)
                return true;
            return false;
        };
       var pos= my(10);
       Console.WriteLine("Value is positive"+"=="+pos);


        Func<string, bool> myd = (str) =>
        {
            if (str.All(char.IsLetter))
                return true;
            return false;
        };
        var only = myd("ChandanKumar");
        Console.WriteLine("Check only alphabet"+"=="+only);

    }
    
}