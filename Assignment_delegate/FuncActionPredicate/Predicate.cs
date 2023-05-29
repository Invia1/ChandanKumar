class Predicate
{ 
    public bool strLength(string str)
    {
        if(str.Length>=5)
            return true;
        return false;
    }  
    public bool Electricity(bool str)
    {
        if(str==true)
        {
            return true;
        }
        else   
             return false;
    }
    public bool checkOnlyCharacter(string str)
    {
        if (str.All(char.IsLetter))
            return true;
        return false;
    }
}
class User
{
    public static void Main()
    {
        Predicate obj = new Predicate();
        Predicate<string> myde = obj.strLength;
        var temp = myde("Radhe");
        Console.WriteLine($"Check Length of String :{temp}");

        Func<string, bool> my = obj.checkOnlyCharacter;
        var ck =my("Radheshyam");
        Console.WriteLine("Predicate apply with Func" + "==" + ck);

        myde = obj.checkOnlyCharacter;
        var tempchar = myde("Radheshyam123");
        Console.WriteLine($"Check Character :{tempchar}");

        Predicate<bool> myde2 = obj.Electricity;
        var temp2 = myde2(false);
        Console.WriteLine($"Electricity Check :{temp2}");


    } 
}