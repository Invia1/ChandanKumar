class Basic
{
    public static void Main()
    {
        Action<int, int> mydel = (x, y) => { Console.WriteLine(x + y); };
        mydel(10, 20);

        Action etiquette = () =>
        {
            Console.WriteLine("Everyone should have Etiquette and Manners");
        };
        etiquette();

        Action<string, string> mydelegate = (str1, str2) =>
        {
           Console.WriteLine(str1+str2); 
        };
        mydelegate("radhe", "shyam");

        
    }
}