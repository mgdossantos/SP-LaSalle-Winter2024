using System;

class Program
{
    static void Main(string[] args)
    {
        int x, y;
        x = 11;
        y = 8;

        float result;
        result = x + y;
        Console.WriteLine("x + y = " + result);
        result = x - y;
        Console.WriteLine("x - y = " + result);
        result = x * y;
        Console.WriteLine("x * y = " + result);
        result = x / y;
        Console.WriteLine("x / y = " + result);
        result = x % y;
        Console.WriteLine("x % y = " + result);

        float a, b;
        a = 11;
        b = 8;
        result = a / b;
        Console.WriteLine("a / b = " + result);
    }
}