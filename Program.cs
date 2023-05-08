using System;

class Assignment
{
    public static void IsPrime(int num)
    {
        int flag = 0;
        int sqrt = (int)Math.Sqrt(num);
        for (int i = 2; i < sqrt; i++)
        {
            if (num % i == 0)
            {
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.WriteLine("Prime Number");
        else
            Console.WriteLine("Is not Prime Number");
    }
    public static void FibonacciSeries(int num)
    {
        int a = 0, b = 1, c = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 2; i < num; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
    public static void FactorialNo(int num)
    {
        if( num ==0 )
        {
            ++num;
        }
        for (int i = num - 1; i >= 1; i--)
        {
            num = num * i;
        }
        Console.WriteLine("factorial value is=" + num);
    }
    public static void Main()
    { 
        Console.WriteLine("1:-Prime Number");
        Console.WriteLine("2:-Fibonacci Series");
        Console.WriteLine("3:-Factorial Number");
        Console.Write("Enter your Choice:-");
        int choice=Convert.ToInt32(Console.ReadLine());
        while (choice != 0)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Check Number is Prime Or Not:-");
                    int num = Convert.ToInt32(Console.ReadLine());
                    IsPrime(num);
                    break;


                case 2:
                    Console.Write("Enter Number for Fibonacci Series:-");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries(num2);
                    break;

                case 3:
                    Console.Write("Enter Number for Factorial Value:-");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    FactorialNo(num3);
                    break;
                default:
                    Console.WriteLine("Wrong Click");
                    break;
            }
            Console.WriteLine("Do you want to Continue the process");
            string process= Console.ReadLine();
            if (process == "yes")
                Main();
            else
                break;
        }
        Console.ReadLine();


    }
}
