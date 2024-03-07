using System;

class Program
{
    static bool checkPrime(int n)
    {
        int result,count=0;
        for(int i = 1; i <= n; i++)
        {
            result = n % i;
            if (result == 0)
            {
                count++;
            }
        }
        if (count ==2)
            return true;
        else 
            return false;
    }

    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Type a number to check: ");
        n= int.Parse(Console.ReadLine());
        Console.WriteLine(checkPrime(n));
    }

    
}