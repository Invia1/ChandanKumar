using System;

class Playway
{
    public int add(int a,int b)
    {
        return a + b;
    }
    public int mul(int a, int b)
    {
        return a * b;
    }
    public int sub(int a,int b)
    {
        return a - b;
    }
    public int div(int a,int b)
    {
        return a / b;
    }
    public int id()
    {
        return 1;
    }
}
class kids
{
    public static void Main()
    {
        Playway obj= new Playway();
        Func<int,int,int> mydel = obj.add;
        var temp=mydel(5, 4);
        Console.WriteLine(temp);

        mydel= obj.mul;
        var temp2=mydel(8, 4);
        Console.WriteLine(temp2);

        mydel=obj.sub;
        var temp3=mydel(1, 4);
        Console.WriteLine(temp3);
        
        mydel= obj.div;
        var temp4=mydel(36, 4);
        Console.WriteLine(temp4);



        Func<int> mydel2= obj.id;
        var a=mydel2();
        Console.WriteLine(a);
       
    }
}