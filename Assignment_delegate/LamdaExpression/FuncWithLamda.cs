class Person
{
    public static void Main()
    {
        Func<int,float,double> obj=(x,y)=> { return x + y; };
        var temp = obj.Invoke(10, 23.4f);
        Console.WriteLine(temp);

        Func<string,string,string> obj2 = (str1,str2) => 
        {
            return str1+str2;
        };
        var temp2 = obj2.Invoke("Radhe","Shyam");
        Console.WriteLine(temp2);


        Func<int> obj3 = () =>
        {
            return 1;
        };
        var temp3= obj3.Invoke();   
        Console.WriteLine(temp3);



        Func<int, double, float, int, int, double, float, int, int,
            int, double, double, int, int, double, float, double> obj4 = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
            {
                return a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p;
            };
        var temp4 = obj4.Invoke(10, 20.00, 30.8f, 40, 50, 58, 34, 23, 45, 33, 66, 77, 11, 33, 55.9, 77.89f);
        Console.WriteLine(temp4);
    }
}